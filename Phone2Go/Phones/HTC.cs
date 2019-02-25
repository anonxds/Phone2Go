using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Phones
{
    class HTC : PhoneC
    {
        private string m_name = "HTC M11";
        private double m_price = 999;
        public override string GetName()
        {
            return m_name;
        }

        public override double GetPrice()
        {
            return m_price;
        }
    }
}
