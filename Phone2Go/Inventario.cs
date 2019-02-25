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
    public partial class Inventario : Form
    {
        Sqlite s = new Sqlite();
        public Inventario()
        {
            InitializeComponent();
            
            s.dgrid(dataGridView1, "select * from Inventario");
            s.populate(cbtipo, "select * from Inventario", "Tipo");

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtinventario.Enabled = true;
        }

        private void txtinventario_TextChanged(object sender, EventArgs e)
        {
            Btnmod.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtinventario.Text))
            {

                Btnmod.Enabled = false;
            }
        }
        public void clean()
        {
            txtnombre.Text = txtcantidad.Text = "";
            btnagregar.Enabled = false;
            cbtipo.Text = txtinventario.Text = null;
            txtinventario.Enabled = Btnmod.Enabled = false;
        }
        private void Btnmod_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update Inventario set Stock = '{0}' where Tipo = '{1}'", txtinventario.Text, cbtipo.Text);
                s.Exe(query);
                MessageBox.Show("Se actualizo la informacion");
                clean();
            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void txtinventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = string.Format("insert into Inventario (Tipo, Stock) values ('{0}','{1}')",txtnombre.Text,txtcantidad.Text);
                s.Exe(query);
                clean();
                s.dgrid(dataGridView1, "select * from Inventario");
                MessageBox.Show("Se inserto el nuevo elemento");
            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            btnagregar.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtcantidad.Text))
            {

                btnagregar.Enabled = false;
            }
        }
    }
}
