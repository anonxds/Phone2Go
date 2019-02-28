
using Phone2Go.Suscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go
{
    public partial class Suscritos : Form
    {
        public Suscritos()
        {
            InitializeComponent();
            select();
        }
        public void select()
        {
            sq.dgrid(metroGrid1, "select * from Subcritores");
        }

        SujetoConcreto s = new SujetoConcreto();
        Sqlite sq = new Sqlite();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Favor de escribir las promociones");
            }
            else
            {
                s.Notifica(richTextBox1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            metroButton1.Enabled = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                metroButton1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroButton2.Enabled = true;

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from Subcritores where Nombre = '{0}'", comboBox1.Text);
            sq.Exe(query);
            s.unsub(comboBox1.SelectedIndex);
            s.Estado = txtemail.Text;
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            metroButton2.Enabled = false;
            select();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los datos");
                }
                else
                {
                    MailMessage mail = new MailMessage("bejeweler2@gmail.com", textBox1.Text, "Reticula", "Listado de patos");
                    string query = string.Format("insert into Subcritores (Nombre,Correo) values ('{0}','{1}')", txtemail.Text, textBox1.Text);
                    sq.Exe(query);
                    s.Sub(new Concreto(txtemail.Text, s, textBox1.Text));
                    //  s.Notifica();
                    comboBox1.Items.Add(txtemail.Text);
                    txtemail.Text = textBox1.Text = "";
                    metroButton1.Enabled = false;
                    select();
                    MessageBox.Show("Se suscribo el usuario");

                }

            }
            catch
            {
                MessageBox.Show("Correo no valido");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
