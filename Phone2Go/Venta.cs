using iTextSharp.text;
using iTextSharp.text.pdf;
using Phone2Go.Phone;
using Phone2Go.Phone.camaras;
using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go
{
    public partial class Venta : Form
    {
        Phones2 Phones;
        Sqlite s = new Sqlite();
 
        Document ticket = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
     
        public Venta()
        {
            InitializeComponent();
            pixel();
            Telefono();
            label10.Text = "0";

        }
        public void pixel()
        {
            string[] pixel = new string[3] { "8mpx", "16mpx", "24mpx" };
            for (int i = 0; i < 3; i++)
            {
                cbcamaras.Items.Add(pixel[i]);
            }
        }
        public void send(TextBox txtemail)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter wri = PdfWriter.GetInstance(ticket, memoryStream);
                ticket.AddTitle("Recibo");
                ticket.AddCreator("Phone2Go");
                ticket.Open();
                ticket.Add(new Paragraph(lblnombretel.Text+" Bateria "+label12.Text+ " Cantidad "+metroLabel1.Text +  " Pantallas "+txtMem.Text + " Camaras "+txtAcce.Text+" Precio " + lblprice.Text ));
                wri.CloseStream = false;
                ticket.Close();
                memoryStream.Position = 0;

                //

                MailMessage mail = new MailMessage("bejeweler2@gmail.com", txtemail.Text, "Ticket", "Recibo");
                mail.Attachments.Add(new Attachment(memoryStream, "Recibo.pdf"));
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("bejeweler2@gmail.com", "");
                client.EnableSsl = true;
                client.Send(mail);
          //      string query = string.Format("insert into Ventas (Telefono,Precio,Correo,Fecha) values('{0}','{1}','{2}','{3}')", lblspecs.Text += lblstorage.Text += lblacc.Text, lblprecio.Text, txtemail.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
           //     s.Exe(query);
               
                MessageBox.Show("Mensaje enviado");

            }
            catch
            {
                MessageBox.Show("Algo sucedio");
            }
        }
        double canP = 0, canB = 0, CanC = 0,finalprice = 0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                canP = canP + double.Parse(txtMem.Text);
                canB = canB + double.Parse(txtcantPila.Text);
                CanC = canB + double.Parse(txtAcce.Text);
                metroLabel1.Text = Convert.ToString(canP);
                string Pantallas = string.Format("update Inventario set Stock = (Stock-'{0}') where Tipo = '{1}'", txtMem.Text, "Pantallas");
               // s.Exe(Pantallas);
                string Baterias = string.Format("update Inventario set Stock = (Stock-'{0}') where Tipo = '{1}'", txtcantPila.Text, "Baterias");
              //  s.Exe(Baterias);
                string Camaras = string.Format("update Inventario set Stock = (Stock-'{0}') where Tipo = '{1}'", txtAcce.Text, "Camaras");
                //  s.Exe(Camaras);
                ticket.Open();
                ticket.Add(new Paragraph(lblnombretel.Text + "Bateria " + label12.Text + "Cantidad" + metroLabel1.Text));
            //    ticket.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ya no hay mas componentes"+ex);
            }

        }
        public void Telefono()
        {
            string[] tel = new string[3] {"HTC","Xperia","AirPhone" };
            for (int i = 0; i < 3; i++)
            {
                cbtelefonos.Items.Add(tel[i]);
            }
        }
    
     
        private void cbtelefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
           txtAcce.Enabled = txtcantPila.Enabled = txtMem.Enabled = true;
            Tel(cbtelefonos,Memoria);
            textBox1.Enabled = true;
        }
        

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void Memoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            Tel(cbtelefonos, Memoria);
        }

        private void cbpila_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public void foryou(Phones2 v,Label precio)
        {
            switch (cbcamaras.Text)
            {
                case "8mpx":
                    precio.Text = Convert.ToString(v.Preciofull());
                    break;
                case "16mpx":
                    precio.Text = Convert.ToString(v.Preciofull());
                    break;
                case "24mpx":
                    precio.Text = Convert.ToString(v.Preciofull());
                    break;
            }
        }
        public void Tel(ComboBox t,ComboBox cb1)
        {
            try
            {

                lblprice.Text = "0";
                label12.Text = "0";
                lblcan.Text = "0";
                 

                switch (t.Text)
                {

                    case "HTC":
                      Phones2   phones = new HTC();

                        Specs(phones, lblprice, lblnombretel,pictureBox1);

                        if (int.Parse(txtMem.Text) >= 1)
                        {
                            phones = new Pantalla(phones);
                            Bat(phones, lblcan, txtMem, lbldescripcionPant);
                        }
                        if (int.Parse(txtcantPila.Text) >= 1)
                        {
                            phones = new Baterias(phones);
                            Bat(phones, label12, txtcantPila, lbldescripcionB);
                        }
                        if (int.Parse(txtAcce.Text) >= 1)
                        {
                            label10.Text = Convert.ToString(double.Parse(label11.Text) * double.Parse(txtAcce.Text));
                            //   phones = new Camaras(phones);
                            // Bat(phones, label10, txtAcce, lbldescripcionCam);
                        }
                        break;
                    case "Xperia":
                        phones = new Xperia();

                        Specs(phones, lblprice, lblnombretel,pictureBox1);

                        if (int.Parse(txtMem.Text) >= 1)
                        {
                            phones = new Pantalla(phones);
                            Bat(phones, lblcan, txtMem, lbldescripcionPant);
                        }
                        if (int.Parse(txtcantPila.Text) >= 1)
                        {
                            phones = new Baterias(phones);
                            Bat(phones, label12, txtcantPila, lbldescripcionB);
                        }
                        if (int.Parse(txtAcce.Text) >= 1)
                        {
                            label10.Text = Convert.ToString(double.Parse(label11.Text) * double.Parse(txtAcce.Text));
                            //     phones = new Camaras(phones);
                            //   Bat(phones, label10, txtAcce, lbldescripcionCam);
                        }
                        break;
                    case "AirPhone":
                        phones = new AirPhone();

                        Specs(phones, lblprice, lblnombretel,pictureBox1);

                        if (int.Parse(txtMem.Text) >= 1)
                        {
                            phones = new Pantalla(phones);
                            Bat(phones, lblcan, txtMem, lbldescripcionPant);
                        }
                        if (int.Parse(txtcantPila.Text) >= 1)
                        {
                            phones = new Baterias(phones);
                            Bat(phones, label12, txtcantPila, lbldescripcionB);
                        }
                        if (int.Parse(txtAcce.Text) >= 1)
                        {
                            label10.Text = Convert.ToString(double.Parse(label11.Text) * double.Parse(txtAcce.Text));
                        }
                        break;

                }
            }
            catch
            {
                MessageBox.Show("El valor es demasiado grande");
            }
            //--
            // erase();

          double  finalpriced = double.Parse(lblcan.Text) + double.Parse(label12.Text) + double.Parse(lblprice.Text) + double.Parse(label10.Text);
            lblprice.Text = Convert.ToString(finalpriced);

        }
        public void erase()
        {
            switch (txtMem.Text)
            {
                case "0":
                    lbldescripcionPant.Text = "";
                    break;

            }
            switch (txtcantPila.Text)
            {
                case "0":
                    lbldescripcionB.Text = "";
                    break;
            }
            switch (txtAcce.Text)
            {
                case "0":
                    lbldescripcionCam.Text = "";
                    break;
            }
        }
        private static void Specs(Phones2 v, Label precio,Label nombre,PictureBox pc)
        {
         precio.Text =Convert.ToString(v.Precio());
            nombre.Text = v.Description();
            v.pic(pc);
        }
        private static void Bat(Phones2 v, Label precio,TextBox can,Label DES)
        {
            DES.Text = v.Description();
            precio.Text = Convert.ToString(v.Preciofull() * double.Parse(can.Text));
        //    Precio1.Text = Convert.ToString(v.Precio() * double.Parse(can.Text));
           
        }




        private void txtMem_TextChanged(object sender, EventArgs e)
        {
            Tel(cbtelefonos, Memoria);

        }

        private void txtcantPila_TextChanged(object sender, EventArgs e)
        {
            Tel(cbtelefonos, Memoria);
        }

        private void txtcantPila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                
                e.Handled = true;
               txtcantPila.Text = "0";
            }
        }

        private void txtMem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAcce_TextChanged(object sender, EventArgs e)
        {
            Tel(cbtelefonos, Memoria);

        }

        private void txtcantPila_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)&& txtcantPila.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnend_Click(object sender, EventArgs e)
        {
            send(textBox1);
        }

        private void txtMem_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtMem.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtAcce_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && txtAcce.Text.Length == 1)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cbcamaras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phones2 Phones;
            switch (cbtelefonos.Text)
            {
                
                case "HTC":
                    
                    switch (cbcamaras.Text)
                    {

                        case "8mpx":
                            Phones = new HTC();
                            Phones = new _8mpx(Phones);
                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                 //           finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "16mpx":
                            Phones = new HTC();
                            Phones = new _16mpx(Phones);

                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
           //                 finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "24mpx":
                            Phones = new HTC();
                            Phones = new _24mpx(Phones);
                          
                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                    }
                    break;
                case "Xperia":
                    switch (cbcamaras.Text)
                    {

                        case "8mpx":
                            Phones = new Xperia();
                            Phones = new _8mpx(Phones);
                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "16mpx":
                            Phones = new Xperia();
                            Phones = new _16mpx(Phones);

                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "24mpx":
                            Phones = new Xperia();
                            Phones = new _24mpx(Phones);

                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                    }
                    break;
                case "AirPhone":
                    switch (cbcamaras.Text)
                    {

                        case "8mpx":
                            Phones = new AirPhone();
                            Phones = new _8mpx(Phones);
                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "16mpx":
                            Phones = new AirPhone();
                            Phones = new _16mpx(Phones);

                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                        case "24mpx":
                            Phones = new AirPhone();
                            Phones = new _24mpx(Phones);

                            label11.Text = Convert.ToString(Phones.Preciofull());
                            label10.Text = Convert.ToString(Phones.Preciofull());
                            finalprice = Phones.Preciofull() + double.Parse(lblprice.Text);
                            lblprice.Text = Convert.ToString(Phones.Precio());
                            break;
                    }
                    break;
            }

            
          
        }

        private void txtAcce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {

                e.Handled = true;
                txtcantPila.Text = "0";
            }
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
