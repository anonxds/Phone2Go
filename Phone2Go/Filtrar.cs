using Phone2Go.Filtros;
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
    public partial class Filtrar : Form
    {
        public Filtrar()
        {
            InitializeComponent();
            filtros();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
           
        }
        Ifiltros filtro;
        private void cbfiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbpor.Items.Clear();
            cbpor.Enabled = true;
            switch (cbfiltrar.Text)
            {
                case "Asesores":

                  
                    textBox1.Enabled = true;
                    filtro = new Asesores();
                    filtro.tabla(metroGrid1);
                    cbpor.Enabled = false;
                    break;
                case "Inventario":
                    string[] In = new string[6] {"Pantalla","Xperia","Airphone","HTC","Camara","Bateria" };
                    for (int i = 0; i < 6; i++)
                    {
                        cbpor.Items.Add(In[i]);
                    }
                    filtro = new Inventarios();
                    filtro.tabla(metroGrid1);
                    textBox1.Enabled = false;
                    cbpor.Enabled = true;
                    break;
                case "Ventas":
                    string[] ven = new string[2] {"Reciente","Lo menos" };
                    for (int i = 0; i < 2; i++)
                    {
                        cbpor.Items.Add(ven[i]);
                    }
                    filtro = new Ventas();
                    filtro.tabla(metroGrid1);
                    textBox1.Enabled = false;
                    cbpor.Enabled = true;
                    break;
                case "Clientes":
                    {
                        filtro = new Subs();
                        filtro.tabla(metroGrid1);
                        textBox1.Enabled = false;
                        cbpor.Enabled = true;
                        break;
                    }



            }
   

        }
        public void fil()
        {
            filtro = new Baterias();
            switch (cbpor.Text)
            {

                case "Bateria":
                    {                  
                        filtro.filtro(metroGrid1,"Baterias");
                        break;
                    }
                case "Camara":
                    filtro.filtro(metroGrid1, "Camara");
                    break;
                case "Pantalla":
                    filtro.filtro(metroGrid1, "Pantalla");
                    break;
                case "Xperia":
                    filtro.filtro(metroGrid1, "Xperia");
                    break;
                case "Airphone":
                    {
                        filtro.filtro(metroGrid1, "Airphone");
                        break;
                    }
                case "HTC":
                    filtro.filtro(metroGrid1, "HTC");
                    break;
            }
        }
        public void filtros()
        {
            string[] fil = new string[4] {"Asesores","Inventario","Ventas","Clientes" };
            for (int i = 0; i < 4; i++)

            {
                cbfiltrar.Items.Add(fil[i]);
            }
        }

        private void cbpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (metroGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'", textBox1.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Filtrar_Load(object sender, EventArgs e)
        {

        }
    }
}
