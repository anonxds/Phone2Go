using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Phone2Go
{
    class Sqlite
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter db;
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=./db.sqlite3;Version=3;New=False;Compress=true;");
        }
        public void Exe(String query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void dgrid(DataGridView dg, string query )
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            db = new SQLiteDataAdapter(query, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dg.DataSource = dt;
            con.Close();
        }
        public void populate(ComboBox cb,string query,string type)
        {
            cb.Items.Clear();
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SQLiteDataAdapter db = new SQLiteDataAdapter(cmd);
            db.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[type]).ToString();
            }


            con.Close();
        }
    }
}
