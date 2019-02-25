using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Telefonos
{
   public sealed class Iphone : Itel
    {
        private string m_name = "Iphone XI";
        private double m_price = 200.00;
        public void Info()
        {
            throw new NotImplementedException();
        }

        public string Infoname()
        {
            return m_name;
        }

        public double price()
        {
            return m_price ;
        }
    }
}
