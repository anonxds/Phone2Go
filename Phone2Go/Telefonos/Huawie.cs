using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Telefonos
{
    class Huawie : Itel
    {
        private string m_name = "Huawie Obvlion";
        private static double m_price = 400.00;
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
            return m_price;
        }
    }
}
