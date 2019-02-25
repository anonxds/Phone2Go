using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Telefonos.Specs
{
    public abstract class Tdecorator : Itel
    {
        Itel _itel = null;
        protected string m_name = "Indefinido";
        protected double m_price = 0.0;
        protected double c_price = 0.0;

        protected Tdecorator(Itel itel)
        {
            this._itel = itel;
           
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public string Infoname()
        {
            return string.Format("{0}", m_name);
        }

        public double price()
        {
            return m_price + _itel.price();
        }
    }
}
