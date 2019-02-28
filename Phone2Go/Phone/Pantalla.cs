using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phones
{
    public class Pantalla : DecoratorP
    {
        private Phones2 _phones;

        public Pantalla(Phones2 phones)
        {
            this._phones = phones;
        }

        public override string Description()
        {
            return "Memoria 8gb";
        }

        public override void pic(PictureBox Ph)
        {
            throw new NotImplementedException();
        }

        public override double Precio()
        {
            return 401 + _phones.Precio();
        }
      

        public override double Preciofull()
        {
            return 400;
        }
    }
  
}
