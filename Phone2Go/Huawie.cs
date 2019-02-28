using Phone2Go.Telefonos;
using Phone2Go.Telefonos.Specs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go
{
    class Huawie2
    {
        public void batery(Label view, ComboBox c3, Camera c, Label bater)
        {
            switch (c3.Text)
            {
                case "1000mah":
                    Bateria b = new Bateria(c);
                    view.Text = b.price().ToString();
                    bater.Text = "-" + b.Infoname().ToString();

                    break;
                case "2000mah":
                    Batteria2 b2 = new Batteria2(c);
                    view.Text = b2.price().ToString();
                    bater.Text = "-" + b2.Infoname().ToString();
                    break;
                case "3000mah":
                    Batteria3 b3 = new Batteria3(c);
                    view.Text = b3.price().ToString();
                    bater.Text = "-" + b3.Infoname().ToString();
                    break;
            }
        }
        public void battery2(Label view, ComboBox c3, camera12 c, Label bater)
        {
            switch (c3.Text)
            {
                case "1000mah":
                    Bateria b = new Bateria(c);
                    view.Text = b.price().ToString();
                    bater.Text = "-" + b.Infoname().ToString();

                    break;
                case "2000mah":
                    Batteria2 b2 = new Batteria2(c);
                    view.Text = b2.price().ToString();
                    bater.Text = "-" + b2.Infoname().ToString();

                    break;
                case "3000mah":
                    Batteria3 b3 = new Batteria3(c);
                    view.Text = b3.price().ToString();
                    bater.Text = "-" + b3.Infoname().ToString();

                    break;
            }
        }
        public void batery3(Label view, ComboBox c3, camera16 c, Label bater)
        {
            switch (c3.Text)
            {
                case "1000mah":
                    Bateria b = new Bateria(c);
                    view.Text = b.price().ToString();
                    bater.Text = "-" + b.Infoname().ToString();

                    break;
                case "2000mah":
                    Batteria2 b2 = new Batteria2(c);
                    view.Text = b2.price().ToString();
                    bater.Text = "-" + b2.Infoname().ToString();

                    break;
                case "3000mah":
                    Batteria3 b3 = new Batteria3(c);
                    view.Text = b3.price().ToString();
                    bater.Text = "-" + b3.Infoname().ToString();

                    break;
            }
        }
        public void fullprice(Label storage, Label bater, Label view, ComboBox c1, ComboBox c2, ComboBox c3, Label spec)
        {
            Huawie i = new Huawie();


            if (c1.Text == "8gb")
            {
                Memoria c = new Memoria(i);
                view.Text = c.price().ToString();
                storage.Text = "-" + c.Infoname().ToString();

                if (c2.Text == "8px")
                {
                    Camera C = new Camera(c);
                    view.Text = C.price().ToString();
                    spec.Text = "-" + C.Infoname().ToString();

                    batery(view, c3, C, bater);



                }
                else if (c2.Text == "12px")
                {
                    camera12 camera12 = new camera12(c);
                    view.Text = camera12.price().ToString();
                    battery2(view, c3, camera12, bater);
                    spec.Text = "-" + camera12.Infoname().ToString();

                }
                else if (c2.Text == "16px")
                {
                    camera16 camera16 = new camera16(c);
                    view.Text = camera16.price().ToString();
                    batery3(view, c3, camera16, bater);
                    spec.Text = "-" + camera16.Infoname().ToString();

                }
            }
            else if (c1.Text == "16gb")
            {
                Memoria16 c = new Memoria16(i);
                view.Text = c.price().ToString();
                storage.Text = "-" + c.Infoname().ToString();

                if (c2.Text == "8px")
                {
                    Camera C = new Camera(c);
                    view.Text = C.price().ToString();
                    batery(view, c3, C, bater);
                    spec.Text = "-" + C.Infoname().ToString();


                }
                else if (c2.Text == "12px")
                {
                    camera12 camera12 = new camera12(c);
                    view.Text = camera12.price().ToString();
                    battery2(view, c3, camera12, bater);
                    spec.Text = "-" + camera12.Infoname().ToString();

                }
                else if (c2.Text == "16px")
                {
                    camera16 camera16 = new camera16(c);
                    view.Text = camera16.price().ToString();
                    batery3(view, c3, camera16, bater);
                    spec.Text = "-" + camera16.Infoname().ToString();

                }
            }
            else if (c1.Text == "32gb")
            {
                Memoria32 c = new Memoria32(i);
                view.Text = c.price().ToString();
                storage.Text = "-" + c.Infoname().ToString();

                if (c2.Text == "8px")
                {
                    Camera C = new Camera(c);
                    view.Text = C.price().ToString();
                    batery(view, c3, C, bater);
                    spec.Text = "-" + C.Infoname().ToString();


                }
                else if (c2.Text == "12px")
                {
                    camera12 camera12 = new camera12(c);
                    view.Text = camera12.price().ToString();
                    battery2(view, c3, camera12, bater);
                    spec.Text = "-" + camera12.Infoname().ToString();

                }
                else if (c2.Text == "16px")
                {
                    camera16 camera16 = new camera16(c);
                    view.Text = camera16.price().ToString();
                    batery3(view, c3, camera16, bater);
                    spec.Text = "-" + camera16.Infoname().ToString();

                }
            }
        }
    }
}

