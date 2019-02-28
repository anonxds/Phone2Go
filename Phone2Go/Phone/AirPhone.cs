using Phone2Go.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phone
{
    public class AirPhone : Phones2
    {
        public AirPhone()
        {
            descripcion = "Air Phone Downfall";
        }

        public override void pic(PictureBox Ph)
        {
             Ph.Image = Properties.Resources.airphone;
        }

        public override double Precio()
        {
            return 3000;
        }

        public override double Preciofull()
        {
            throw new NotImplementedException();
        }
    }
}
