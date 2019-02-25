
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
            
            s.Sub(new Concreto(txtemail.Text, s));
            //  s.Notifica();
            comboBox1.Items.Add(txtemail.Text);
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {


            s.unsub(comboBox1.SelectedIndex);
            s.Estado = txtemail.Text;
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            s.Notifica();
        }

    }
}
