using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phone
{
    //Ventajas, desventajas cobit e itil
    public class Baterias : DecoratorP
    {
        private Phones2 _phones;
        public Baterias(Phones2 phones)
        {
            this._phones = phones;
        }

        public override string Description()
        {
            return "Simple bateria";
        }

        public override void pic(PictureBox Ph)
        {
            throw new NotImplementedException();
        }

        public override double Precio()
        {
            return 400 + _phones.Precio();
        }

        public override double Preciofull()
        {
            return 400;
        }
    }
}
