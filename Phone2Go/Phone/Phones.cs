using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Phones
{
  public abstract  class Phones2
    {
        protected string descripcion = "Telefono generico";
        public virtual string Description()
        {
            return descripcion;
        }
        public abstract double Precio();
        public abstract double Preciofull();
        public abstract void pic(PictureBox Ph);
      

    }
}
