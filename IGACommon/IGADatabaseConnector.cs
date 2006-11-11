using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace au.id.micolous.libs.igacommon
{
	/// <summary>
	/// Description of IGADatabaseConnector.
	/// </summary>
	public class IGADatabaseConnector
	{
		private SQLiteConnection sqlite;
		private int _appID;
		private bool _appSupported;
        private AppInfo _appInfo;
        /// <summary>
        /// The AppInfo for the current connection.  If AppSupported is false,
        /// then this will be incorrect.
        /// </summary>
        public AppInfo appInfo { get { return _appInfo; } }

        /// <summary>
        /// Returns true if the "MinTime" property is stored in seconds, rather
        /// than milliseconds.  Some old versions of the IGA library do this.
        /// </summary>
        public bool MinTimeStoredInSeconds
        {
            get
            {
                // TODO: confirm when appid first started using milliseconds in newer apps
                // at the moment set to trackmania nations (27).
                if (_appID <= 27)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// This is set to true if the application is properly supported by the connector.
        /// </summary>
        public bool AppSupported { get { return _appSupported; } }
		
		/// <summary>
		/// The application ID of the program, or '0' if there is none.
		/// 
		/// If there is none, you will need to call ChangeAppID() before playing
		/// around with the database.
		/// 
		/// If you set this value, then it will NOT be committed to the database.
		/// </summary>
		public int AppID { 
			get { return this._appID; } 
			set { 
				this._appID = value;
				this._appSupported = Common.AppInfos.ContainsKey(this._appID);
                if (this._appSupported)
                {
                    _appInfo = Common.AppInfos[this._appID];
                }
			}
		}
		
		/// <summary>
		/// Creates a new connection to the icontent.cache file.
		/// </summary>
		/// <param name="filename">The file to connect to.</param>
		public IGADatabaseConnector(String filename)
		{
			
			try {
				sqlite = new SQLiteConnection("Data Source=\"" + filename + "\"");
				sqlite.Open();
				SQLiteCommand query = new SQLiteCommand("SELECT [appId] FROM [contentlist] LIMIT 1", sqlite);
				Object result = query.ExecuteScalar();
				sqlite.Close();
				if (result == null)
				{
					this._appID = 0;
				}
				else
				{
					this._appID = (int)(long)result;
				}
				
				if (this._appID > 0) {
					this._appSupported = Common.AppInfos.ContainsKey(this._appID);
				} else {
					this._appSupported = false;
				}

                if (this._appSupported)
                {
                    _appInfo = Common.AppInfos[this._appID];
                }
				
			} catch (Exception) {
				throw new DatabaseConnectionFailureException();
			}
		}
		
		/// <summary>
		/// This method changes the AppID of the active cache file.
		/// </summary>
		/// <param name="AppID">The new AppID of the program.</param>
		public void ChangeAppID(int AppID) {
			// try to write back
			SQLiteCommand query = new SQLiteCommand(@"UPDATE [contentlist] SET [appid]=@appid", sqlite);
			query.Parameters.Add(new SQLiteParameter("appid", AppID));
			sqlite.Open();
			if (query.ExecuteNonQuery() == 0)
			{
				// no data in contentlist... add new.
				sqlite.Close();
				query = new SQLiteCommand(@"INSERT INTO [contentlist] ([appid]) VALUES (@appid)", sqlite);
				query.Parameters.Add(new SQLiteParameter("appid", AppID));
				sqlite.Open();
				query.ExecuteNonQuery();
			}
            sqlite.Close();

            this.AppID = AppID;
		}


        /// <summary>
        /// Dumps all entries from the database into an array.
        /// </summary>
        /// <param name="IncludeImageData">Set this to true if you want to export
        /// image/video data with it.  Setting this to true will increase
        /// the amount of memory needed to dump.</param>
        /// <returns>A SortedDictionary copy of the database.</returns>
        public SortedDictionary<uint, ContentEntry> GetAllEntries(bool IncludeImageData)
        {
            SortedDictionary<uint, ContentEntry> items = new SortedDictionary<uint, ContentEntry>();

            SQLiteCommand cmd = sqlite.CreateCommand();
            cmd.CommandText = @"SELECT * FROM [content] ORDER BY [contentId]";
            sqlite.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ContentEntry entry = this.GetEntryFromReader(reader, IncludeImageData);
                items.Add(entry.ContentID, entry);
            }
            sqlite.Close();

            return items;
        }

        /// <summary>
        /// Executes a "VACCUM" query on the database.  This frees unused
        /// space that the database has allocated.
        /// </summary>
        public void VaccumDatabase()
        {
            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand("VACUUM", sqlite);
            query.ExecuteNonQuery();
            sqlite.Close();
        }

        /// <summary>
        /// Creates a copy of the internal SQLite connection object.
        /// 
        /// This is only intended for use in debugging, NOT everyday operations.
        /// </summary>
        /// <returns>A copy of the SQLiteConnection that this instance of the class is
        /// presently using.</returns>
        public SQLiteConnection GetConnection()
        {
            return (SQLiteConnection)sqlite.Clone();
        }


        /// <summary>
        /// Imports a single image into the database.
        /// </summary>
        /// <param name="contentId">The position to place the image.</param>
        /// <param name="ddsimage">The image data.</param>
        public void ImportImage(uint contentId, byte[] ddsimage)
        {
            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand(@"UPDATE [content] SET [data] = @data, [size] = @size WHERE [contentId] = @cid", sqlite);
            SQLiteParameter d = new SQLiteParameter("data", ddsimage);
            SQLiteParameter s = new SQLiteParameter("size", ddsimage.Length);
            SQLiteParameter c = new SQLiteParameter("cid", contentId);
            query.Parameters.Add(c);
            query.Parameters.Add(s);
            query.Parameters.Add(d);
            query.ExecuteNonQuery();
            sqlite.Close();
        }

        /// <summary>
        /// Exports a single image from the database.
        /// </summary>
        /// <param name="contentId">The contentId to export.</param>
        /// <returns>A byte[] containing the raw image or video data.</returns>
        public byte[] ExportImage(uint contentId)
        {
            SQLiteCommand cmd = new SQLiteCommand(@"SELECT [data] FROM [content] WHERE [contentId] = @cid LIMIT 1", sqlite);
            cmd.Parameters.Add(new SQLiteParameter("cid", contentId));
            sqlite.Open();
            byte[] idata = (byte[])cmd.ExecuteScalar();
            sqlite.Close();
            return idata;
        }

        /// <summary>
        /// Imports a new entry into the database from an adpack.
        /// </summary>
        /// <param name="ad">The AdPackEntry to import.</param>
        public uint NewEntry(AdPackEntry ad)
        {
            ContentEntry entry = new ContentEntry();
            entry.Size = (uint)ad.DDSData.Length;
            entry.Data = ad.DDSData;
            return this.NewEntry(entry);

        }

        /// <summary>
        /// Creates a new entry in the cache file.
        /// </summary>
        /// <param name="entry">The entry to create.</param>
        /// <returns>The new entry's contentId.</returns>
        public uint NewEntry(ContentEntry entry)
        {
            uint active = 1;
            if (!entry.Active)
            {
                active = 0;
            }
            uint activate = (uint)((TimeSpan)entry.Activate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            uint expiry = 0;
            if (entry.Expires)
            {
                expiry = (uint)((TimeSpan)entry.Expiry.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            }

            String p = entry.GetPropsAsString();

            SQLiteCommand query = new SQLiteCommand(@"INSERT INTO [content] ([active], [activate], [expire], [dayparts], [contentType], [descriptor], [size], [viewcount], [viewlimit], [displayafter], [props]) VALUES (@active, @activate, @expire, @dayparts, @contentType, @descriptor, @size, @viewcount, @viewlimit, @displayafter, @props); SELECT last_insert_rowid() AS contentId;", sqlite);
            query.Parameters.Add(new SQLiteParameter("active", active));
            query.Parameters.Add(new SQLiteParameter("activate", activate));
            query.Parameters.Add(new SQLiteParameter("expire", expiry));
            query.Parameters.Add(new SQLiteParameter("dayparts", entry.DayParts));
            query.Parameters.Add(new SQLiteParameter("contentType", entry.contentType.contentType));
            query.Parameters.Add(new SQLiteParameter("descriptor", entry.Descriptor));
            query.Parameters.Add(new SQLiteParameter("size", entry.Size));
            query.Parameters.Add(new SQLiteParameter("viewcount", entry.ViewCount));
            query.Parameters.Add(new SQLiteParameter("viewlimit", entry.ViewLimit));
            query.Parameters.Add(new SQLiteParameter("displayafter", entry.DisplayAfter));
            query.Parameters.Add(new SQLiteParameter("props", p));
            // get the contentId back
            sqlite.Open();
            Object cidR = query.ExecuteScalar();
            uint cid = (uint)((long)cidR);
            
            // shove cid into props
            p = "contentId=" + cid.ToString() + "&" + p;

            // reset connection
            sqlite.Close();
            sqlite.Open();

            query = new SQLiteCommand(@"UPDATE [content] SET [props]=@props WHERE [contentId]=@cid", sqlite);
            query.Parameters.Add(new SQLiteParameter("props", p));
            query.Parameters.Add(new SQLiteParameter("cid", cid));
            query.ExecuteNonQuery();

            sqlite.Close();

            return cid;

        }

        /// <summary>
        /// Overload that allows you to import an AdPackEntry over an existing item,
        /// instead of reading raw image data.
        /// </summary>
        /// <param name="contentId">The contentId to overwrite.</param>
        /// <param name="ad">The AdPackEntry with the data to insert.</param>
        public void ImportImage(uint contentId, AdPackEntry ad)
        {
            ImportImage(contentId, ad.DDSData);
        }

        /// <summary>
        /// Updates the entry an the specified contentId.
        /// </summary>
        /// <param name="contentID">The contentId to update.</param>
        /// <param name="entry">The new content of the row.</param>
        /// <param name="UpdateData">Should the image/video data column be updated?</param>
        public void EditEntry(uint contentID, ContentEntry entry, bool UpdateData)
        {
            uint active = 1;
            if (!entry.Active)
            {
                active = 0;
            }
            uint activate = (uint)((TimeSpan)entry.Activate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            uint expiry = 0;
            if (entry.Expires)
            {
                expiry = (uint)((TimeSpan)entry.Expiry.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            }

            String propS = entry.GetPropsAsString();


            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand(@"UPDATE [content] SET [active]=@active, [activate]=@activate, [expire]=@expire, [dayparts]=@dayparts, [contentType]=@contentType, [descriptor]=@descriptor, [size]=@size, [viewcount]=@viewcount, [viewlimit]=@viewlimit, [displayafter]=@displayafter, [props]=@props WHERE [contentId]=@cid", sqlite);
            //query = new SQLiteCommand(@"UPDATE [content] SET [active]=@active, [activate]=@activate, [expire]=@expire, [props]=@props WHERE [contentId]=@cid", sqlite);
            query.Parameters.Add(new SQLiteParameter("cid", contentID));
            query.Parameters.Add(new SQLiteParameter("active", active));
            query.Parameters.Add(new SQLiteParameter("activate", activate));
            query.Parameters.Add(new SQLiteParameter("expire", expiry));
            query.Parameters.Add(new SQLiteParameter("dayparts", entry.DayParts));
            query.Parameters.Add(new SQLiteParameter("contentType", entry.contentType.contentType));
            query.Parameters.Add(new SQLiteParameter("descriptor", entry.Descriptor));
            query.Parameters.Add(new SQLiteParameter("size", entry.Size));
            query.Parameters.Add(new SQLiteParameter("viewcount", entry.ViewCount));
            query.Parameters.Add(new SQLiteParameter("viewlimit", entry.ViewLimit));
            query.Parameters.Add(new SQLiteParameter("displayafter", entry.DisplayAfter));
            query.Parameters.Add(new SQLiteParameter("props", propS));

            if (query.ExecuteNonQuery() != 1)
            {
                throw new DatabaseUpdateFailureException();
            }
            sqlite.Close();

            if (UpdateData)
            {
                this.ImportImage(contentID, entry.Data);
            }

        }

        /// <summary>
        /// Fetches the entry at the contentId specified, and returns a ContentEntry
        /// that is the row.
        /// </summary>
        /// <param name="contentId">The contentId to fetch.</param>
        /// <param name="IncludeImageData">Should image data be included?</param>
        /// <returns>A ContentEntry that is the row.</returns>
        public ContentEntry GetEntry(uint contentId, bool IncludeImageData)
        {
            SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM [content] WHERE [contentId] = @cid LIMIT 1", sqlite);
            cmd.Parameters.Add(new SQLiteParameter("cid", contentId));
            sqlite.Open();
            ContentEntry entry;
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            entry = this.GetEntryFromReader(reader, IncludeImageData);
            sqlite.Close();
            return entry;
        }

        /// <summary>
        /// Internal function to read a row from a SQLiteDataReader to convert
        /// it to a ContentEntry.
        /// </summary>
        /// <param name="reader">The SQLiteDataReader to get the information from.</param>
        /// <param name="IncludeImageData">Should image data be included?</param>
        /// <returns>A ContentEntry describing the row returned.</returns>
        private ContentEntry GetEntryFromReader(SQLiteDataReader reader, bool IncludeImageData)
        {
            ContentEntry entry = new ContentEntry();

            // read in rows
            entry.ContentID = (uint)reader.GetInt32(0);

            DateTime activate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            entry.Activate = activate.AddSeconds(reader.GetInt32(2));

            entry.Active = (reader.GetInt32(1) >= 1);

            if (reader.GetInt32(3) > 0)
            {
                DateTime expires = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                entry.Expiry = expires.AddSeconds(reader.GetInt32(3));
                entry.Expires = true;
            }
            else
            {
                entry.Expires = false;
            }

            entry.DayParts = (uint)reader.GetInt32(4);

            entry.contentType = new ContentType((uint)reader.GetInt32(5));

            entry.Size = (uint)reader.GetInt32(7);
            entry.ViewCount = (uint)reader.GetInt32(8);
            entry.ViewLimit = (uint)reader.GetInt32(9);
            entry.DisplayAfter = (uint)reader.GetInt32(10);

            // parse properties.
            String props = reader.GetString(11);
            entry.Properties = new SortedDictionary<string, string>();

            foreach (String prop in props.Split('&'))
            {
                if (prop.Length > 0)
                {
                    String[] pk = prop.Split('=');
                    entry.Properties.Add(pk[0], pk[1]);
                }
            }

            if (IncludeImageData)
            {
                long fileLength;
                try
                {
                    fileLength = reader.GetBytes(12, 0, null, 0, 0);
                }
                catch (Exception ex)
                {
                    // data blob is empty
                    ex.ToString();
                    fileLength = 0;
                }
                byte[] ddsimage = new byte[fileLength];
                if (fileLength > 0)
                {
                    reader.GetBytes(12, 0, ddsimage, 0, ddsimage.Length);
                }

                entry.Data = ddsimage;
            }

            return entry;
        }

        /// <summary>
        /// Deletes a record from the database.
        /// </summary>
        /// <param name="contentId">The record's contentId to delete.</param>
        public void DeleteEntry(uint contentId)
        {
            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand(@"DELETE FROM [content] WHERE [contentId]=@cid", sqlite);
            query.Parameters.Add(new SQLiteParameter("cid", contentId));
            if (query.ExecuteNonQuery() != 1)
            {
                sqlite.Close();
                throw new DatabaseUpdateFailureException();
            }
            sqlite.Close();
        }
	}
}
