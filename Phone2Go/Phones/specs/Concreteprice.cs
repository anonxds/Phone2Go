using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Phones.specs
{
    class Concreteprice : Pdecorator
    {
        public Concreteprice(PhoneC phone) : base(phone)
        {
            this.m_nombre = "8gb";
            this.m_price = 4;
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
