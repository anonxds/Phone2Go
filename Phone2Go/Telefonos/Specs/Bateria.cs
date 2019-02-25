using Phone2Go.Telefonos;
using Phone2Go.Telefonos.Specs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go
{
    class Bateria : Tdecorator
    {
        public Bateria(Itel itel) : base(itel)
        {
            this.m_name = "1000mah";
            this.m_price = 1299;
        }
    }
    class Batteria2 : Tdecorator
    {
        public Batteria2(Itel itel) : base(itel)
        {
            this.m_name = "2000mah";
            this.m_price = 2000;
        }
    }
    class Batteria3 : Tdecorator
    {
        public Batteria3(Itel itel) : base(itel)
        {
            this.m_name = "3000mah";
            this.m_price = 3000;
        }
    }
}
