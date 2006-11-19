using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using Mono.Data.SqliteClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This form provides a simple SQLite GUI.  It doesn't do a lot, nor does
    /// it insulate a lot.
    /// 
    /// It is provided to allow users to send custom SQL queries to SQLite
    /// without the need for extra software installation.
    /// </summary>
    partial class SqlInjectorForm : Form
    {

        private SqliteConnection sqlite;
        private SqliteDataReader result;

        /// <summary>
        /// Creates a new instance of the form.  You must pass a closed
        /// SqliteConnection to the constructor to use it.
        /// </summary>
        /// <param name="sqlite">The SqliteConnection to use.</param>
        public SqlInjectorForm(SqliteConnection sqlite)
        {
            InitializeComponent();
            this.sqlite = sqlite;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            QueryTextBox.Text = QueryTextBox.Text.Trim();
            if (QueryTextBox.Text.Length == 0)
            {
                MessageBox.Show("No query entered.");
                return;
            }

            SqliteCommand query = new SqliteCommand(QueryTextBox.Text, sqlite);
            sqlite.Open();
            ResultTextbox.Clear();
            try
            {
                result = query.ExecuteReader();
            }
            catch (Exception ex)
            {
                ResultTextbox.AppendText(String.Format("Got {0} while trying to execute query.  The message was: {1}", ex.GetType().ToString(), ex.Message));
                sqlite.Close();
                return;
            }

            //if (result.HasRows)
            //{
            int rowCount = 0;
            while (result.Read())
            {
                for (int x = 0; x < result.FieldCount; x++)
                {
                    // iterate columns
                    ResultTextbox.AppendText(result.GetValue(x).ToString() + "|");
                }

                // eol
                ResultTextbox.AppendText("\r\n");
                rowCount++;
            }
            result.Close();
            //}
            //else
            if (rowCount == 0)
            {
                //result.Close();
                ResultTextbox.AppendText("The query you entered was performed successfully, but no rows were returned.\r\n\r\n");
                ResultTextbox.AppendText(String.Format("{0} row(s) were effected by the query.", result.RecordsAffected));
            }
            ResultTextbox.SelectionStart = 0;
            ResultTextbox.SelectionLength = 0;
            ResultTextbox.ScrollToCaret();
            sqlite.Close();
        }
    }
}