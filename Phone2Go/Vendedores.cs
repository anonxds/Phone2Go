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
    public partial class Vendedores : Form
    {
        Sqlite s = new Sqlite();
        public Vendedores()
        {
            InitializeComponent();
            cbtipo.Items.Add("kek");
            s.dgrid(metroGrid1, "select * from Asesores");
            s.populate(cbtipo, "select * from Asesores", "Nombre");
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroButton3.Enabled = true;
            txtusuario.Enabled = true;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            metroButton2.Enabled = true;
           
            if (string.IsNullOrWhiteSpace(txtusuario.Text))
            {
                
                metroButton2.Enabled = false;
            }
        }
        public void clean()
        {
            txtcontra.Text = txtedad.Text = txtnombre.Text = txtusuario.Text = cbtipo.Text = null;
      metroButton3.Enabled =   txtusuario.Enabled = metroButton2.Enabled = false;

        }

        private void Btnmod_Click(object sender, EventArgs e)
        {
          
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update Asesores set Nombre = '{0}' where Nombre = '{1}'", txtusuario.Text, cbtipo.Text);
                s.Exe(query);

                MessageBox.Show("Se actualizo la informacion");
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo sucedio" + ex);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from Asesores where Nombre = '{0}'", cbtipo.Text);
                s.Exe(query);
                MessageBox.Show("Se dio de baja el usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo sucedio" + ex);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == "" || txtedad.Text == "" || txtcontra.Text == "")
                {
                    MessageBox.Show("Favor de llenar los datos.");
                }
                else
                {
                    string query = string.Format("insert into Asesores (Nombre,Edad,Password)values ('{0}','{1}','{2}')", txtnombre.Text, txtedad.Text, txtcontra.Text);
                    s.Exe(query);
                    MessageBox.Show("Se registro con exito");
                    clean();
                    s.dgrid(metroGrid1, "select * from Asesores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo sucedio" + ex);
            }
        }
    }
}
