
using Phone2Go.Suscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        SujetoConcreto s = new SujetoConcreto();
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los datos");
                }
                else
                {
                    s.Sub(new Concreto(txtemail.Text, s,textBox1.Text));
                    //  s.Notifica();
                    comboBox1.Items.Add(txtemail.Text);
                    txtemail.Text = textBox1.Text = "";
                    btnagregar.Enabled = false;
                    MessageBox.Show("Se suscribo el usuario");
                }

            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {


            s.unsub(comboBox1.SelectedIndex);
            s.Estado = txtemail.Text;
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            btnquitar.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            s.Notifica();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnagregar.Enabled = true;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                btnagregar.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnquitar.Enabled = true;

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
