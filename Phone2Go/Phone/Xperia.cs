using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phone
{
    class Xperia : Phones2
    {
        public Xperia()
        {
            descripcion = "Xperia Oathmaker";
        }

        public override void pic(PictureBox Ph)
        {
            Ph.Image = Properties.Resources.xperia;
        }

        public override double Precio()
        {
            return 1200.00;
        }

        public override double Preciofull()
        {
            throw new NotImplementedException();
        }
    }
}
