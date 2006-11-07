using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace au.id.micolous.apps.igaeditor
{
    class AdPackCommon
    {
        public static void NewAdEntry(AdPackEntry ad)
        {
            SQLiteConnection sqlite = Common.sqlite;
            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand(@"INSERT INTO [content] ([active], [activate], [expire], [dayparts], [contentType], [descriptor], [size], [viewcount], [viewlimit], [displayafter], [props], [data]) VALUES (@active, @activate, 0, @dayparts, @contentType, @descriptor, @size, 0, 0, 0, @props, @data); SELECT last_insert_rowid() AS contentId;", sqlite);
            query.Parameters.Add(new SQLiteParameter("active", 1));
            int time = (int)(DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            String p = "Activate=" + time.ToString() + "&CellDescriptors=31&CellDiscriptor=31&contentType=" + ad.ContentType + "&DayParts=16777215&Deflection=80&DisplayAfter=0&Expire=0&MaxSize=100&MinSize=4&MinTime=2000&PerUserLimit=0&Size=" + ad.DDSData.Length.ToString() + "&userInfo=m18&zoneId=16&";
            query.Parameters.Add(new SQLiteParameter("activate", time));
            //query.Parameters.Add(new SQLiteParameter("expire", 0));
            query.Parameters.Add(new SQLiteParameter("dayparts", 16777215));
            query.Parameters.Add(new SQLiteParameter("contentType", ad.ContentType));
            query.Parameters.Add(new SQLiteParameter("descriptor", "31"));
            query.Parameters.Add(new SQLiteParameter("size", ad.DDSData.Length));
            //query.Parameters.Add(new SQLiteParameter("viewcount", 0));
            //query.Parameters.Add(new SQLiteParameter("viewlimit", 0));
            //query.Parameters.Add(new SQLiteParameter("displayafter", 0));
            query.Parameters.Add(new SQLiteParameter("props", p));
            query.Parameters.Add(new SQLiteParameter("data", ad.DDSData));
            // get the contentId back
            Object cidR = query.ExecuteScalar();
            int cid = (int)((long)cidR);
            //MessageBox.Show("New CID was #" + cid.ToString() + ".");
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
        }

        public static void ReplaceAdEntry(int contentId, AdPackEntry ad)
        {
            SQLiteConnection sqlite = Common.sqlite;
            try
            {
                // now write back to db
                sqlite.Open();
                SQLiteCommand query = new SQLiteCommand(@"UPDATE [content] SET [data] = @data, [size] = @size WHERE [contentId] = @cid", sqlite);
                SQLiteParameter d = new SQLiteParameter("data", ad.DDSData);
                SQLiteParameter s = new SQLiteParameter("size", ad.DDSData.Length);
                SQLiteParameter c = new SQLiteParameter("cid", contentId);
                query.Parameters.Add(c);
                query.Parameters.Add(s);
                query.Parameters.Add(d);
                query.ExecuteNonQuery();
                sqlite.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure committing data to database.\r\n\r\nIt is recommended you restart this program.\r\n\r\nThe error was: " + ex.Message);
                return;
            }
        }
    }
}
