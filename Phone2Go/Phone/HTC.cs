using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phones
{
    public class HTC : Phones2
    {
        public HTC()
        {
            descripcion = "HTC MAX";
        }

        public override void pic(PictureBox Ph)
        {
            Ph.Image = Properties.Resources.htc;
        }

        public override double Precio()
        {
            return 999.00;
        }

        public override double Preciofull()
        {
            throw new NotImplementedException();
        }
    }
}
