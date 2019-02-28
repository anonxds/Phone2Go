using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phone
{
    public class Camaras : DecoratorP
    {
        private Phones2 _phones;
        public Camaras(Phones2 phones)
        {
            this._phones = phones;
        }
        public override string Description()
        {
            return "Una camara con 99mpx";
        }

        public override void pic(PictureBox Ph)
        {
            throw new NotImplementedException();
        }

        public override double Precio()
        {
            return 300 + _phones.Precio();
        }

        public override double Preciofull()
        {
            return 300;
        }
    }
}
