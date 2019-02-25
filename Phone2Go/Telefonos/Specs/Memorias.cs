using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Telefonos.Specs
{
    class Memoria : Tdecorator
    {
       
        public Memoria(Itel itel) : base(itel)
        {
            this.m_name = "8gb";
            this.m_price = 3;
        }
    }
    class Memoria16 : Tdecorator
    {
        public Memoria16(Itel itel) : base(itel)
        {
            this.m_name = "16gb";
            this.m_price = 10;
        }
    }
    class Memoria32 : Tdecorator
    {
        public Memoria32(Itel itel) : base(itel)
        {
            this.m_name = "32gb";
            this.m_price = 44;
        }

    }
}
