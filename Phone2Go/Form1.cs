using Phone2Go.Telefonos;
using Phone2Go.Telefonos.Specs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net.Mail;

namespace Phone2Go
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
           
            fill();
            Fills();
            camera();
            Pila();
            cbPhones.Enabled = true;
           
        }
        public void fill()
        {
            Itel iphone, huawie, pixel;
            iphone = new Iphone();
            huawie = new Huawie();
            pixel = new Pixel();
            string[] p = new string[3] { iphone.Infoname(),huawie.Infoname(),pixel.Infoname() };
            for (int i = 0; i < 3; i++)
            {
                cbPhones.Items.Add(p[i]);
            }

           
        }

        private void cbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStorage.Enabled = true;
            Itel iphone, huawie, pixel;
            iphone = new Iphone();
            huawie = new Huawie();
            pixel = new Pixel();
          
            switch (cbPhones.Text)
            {
                case "Iphone XI":
                    lblprecio.Text = iphone.price().ToString();
                    lblspecs.Text = iphone.Infoname().ToString();
                    break;
                case "Huawie Obvlion":
                    lblprecio.Text = huawie.price().ToString();
                    lblspecs.Text = huawie.Infoname().ToString();
                    break;
                case "Google Pixel nEO":
                    lblprecio.Text = pixel.price().ToString();
                    lblspecs.Text = pixel.Infoname().ToString();
                    break;
            }
        }
        public void Fills()
        {
            string[] s = new string[3] { "8gb", "16gb", "32gb" };
            for (int i = 0; i < 3; i++)
            {
                cbStorage.Items.Add(s[i]);
            }
        }
        public void camera()
        {
            string[] s = new string[3] { "8px", "12px", "16px" };
            for (int i = 0; i < 3; i++)
            {
                cbCamera.Items.Add(s[i]);
            }
        }
        public void Pila()
        {
            string[] A = new string[3] {"1000mah","2000mah","3000mah" };
            for (int i = 0; i < 3; i++)
            {
                comboBox3.Items.Add(A[i]);
            }
        }

        Iphone i = new Iphone();
        private void cbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCamera.Enabled = true;
            switch (cbPhones.SelectedIndex)
            {
                case 0:
                    Price p = new Price();
                    p.fullprice(lblbateria,lblprecio, cbStorage, cbCamera, comboBox3,lblcamara);
                    break;
                case 1:
                    Huawie2 h = new Huawie2();
                    h.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
                case 2:
                    Pixel2 pi = new Pixel2();
                    pi.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
            }
        

        }

        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            switch (cbPhones.SelectedIndex)
            {
                case 0:
                    Price p = new Price();
                    p.fullprice(lblbateria,lblprecio, cbStorage, cbCamera, comboBox3,lblcamara);
                    break;
                case 1:
                    Huawie2 h = new Huawie2();
                    h.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
                case 2:
                    Pixel2 pi = new Pixel2();
                    pi.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
            }
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtemail.Visible = true;
          //  btncont.Enabled = true;
            switch (cbPhones.SelectedIndex)
            {
                case 0:
                    Price p = new Price();
                    p.fullprice(lblbateria,lblprecio, cbStorage, cbCamera, comboBox3,lblcamara);
                    break;
                case 1:
                    Huawie2 h = new Huawie2();
                    h.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
                case 2:
                    Pixel2 pi = new Pixel2();
                    pi.fullprice(lblprecio, cbStorage, cbCamera, comboBox3);
                    break;
            }
        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtemail.Visible = false;
            cbStorage.Text = cbCamera.Text = cbPhones.Text = comboBox3.Text = lblspecs.Text = lblbateria.Text = lblprecio.Text = null;
            cbStorage.Text = cbCamera.Text = cbPhones.Text = comboBox3.Text = lblspecs.Text = lblbateria.Text = lblprecio.Text = "";
            cbCamera.Enabled = cbStorage.Enabled = comboBox3.Enabled = btncont.Enabled = false;
            txtemail.Visible = false;
        }
        public void limpiar()
        {
            txtemail.Visible = false;
            cbStorage.Text = cbCamera.Text = cbPhones.Text = comboBox3.Text = lblspecs.Text = lblbateria.Text = lblprecio.Text = null;
            cbStorage.Text = cbCamera.Text = cbPhones.Text = comboBox3.Text = lblspecs.Text = lblbateria.Text = lblprecio.Text = "";
            cbCamera.Enabled = cbStorage.Enabled = comboBox3.Enabled = btncont.Enabled = false;
            txtemail.Visible = false;
        }
        private void btncont_Click(object sender, EventArgs e)
        {
            Document ticket = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter wri = PdfWriter.GetInstance(ticket, memoryStream);
            ticket.AddTitle("Recibo");
            ticket.AddCreator("Phone2Go");
            ticket.Open();
            ticket.Add(new Paragraph(lblspecs.Text + lblspecs.Text + lblcam.Text + lblbateria.Text + lblprecio.Text));
            wri.CloseStream = false;
            ticket.Close();
            memoryStream.Position = 0;

            //

            MailMessage mail = new MailMessage("bejeweler2@gmail.com", txtemail.Text, "Reticula", "Listado de patos");
            mail.Attachments.Add(new Attachment(memoryStream, "Recibo.pdf"));
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("bejeweler2@gmail.com", "bejeweled2012");
            client.EnableSsl = true;
            client.Send(mail);
            limpiar();
            txtemail.Text = "";
            MessageBox.Show("Mensaje enviado");
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            btncont.Enabled = true;
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                btncont.Enabled = false;
            }
        }
    }
}
