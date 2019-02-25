using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Phones.specs
{
    public abstract class Pdecorator : PhoneC
    {
        PhoneC _phoneC = null;
        protected string m_nombre = "Indefinido";
        protected double m_price = 0.0;
        protected Pdecorator(PhoneC phone)
        {
            _phoneC = phone;
        }
        #region PhoneC Members
        string Getname()
        {
            return string.Format("{0}", _phoneC.GetName());
        }
        double Getprice()
        {
            return m_price + _phoneC.GetPrice();
        }
        #endregion
    }
}
