using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phone.camaras
{
    class _8mpx : DecoratorP
    {
        private Phones2 _phones;
        public _8mpx(Phones2 phones)
        {
            this._phones = phones;
        }

        public override string Description()
        {
            return "Una camara de 8mpx";
        }

        public override void pic(PictureBox Ph)
        {
            throw new NotImplementedException();
        }

        public override double Precio()
        {
            return 40 + _phones.Precio();
        }

        public override double Preciofull()
        {
            return 40;
        }
    }
}
