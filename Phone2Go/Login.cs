using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Phone2Go
{
    public partial class Login : Form
    {
        Sqlite s = new Sqlite();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaccess_Click(object sender, EventArgs e)
        {
            try
            {
                string cn = "Data Source=./db.sqlite3;Version=3;New=False;Compress=true;";
                SQLiteConnection con = new SQLiteConnection(cn);
                con.Open();
                string query = string.Format("select * from Asesores where Nombre = '{0}' and Password = '{1}'", textBox1.Text, textBox2.Text);
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                SQLiteDataReader l = cmd.ExecuteReader();
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Favor de llenar los datos");
                }
                if (textBox1.Text == "Admin" && textBox2.Text == "1234")
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                }
                if (l.Read())
                {
                    this.Hide();
                    Menu m = new Menu();
                    m.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
