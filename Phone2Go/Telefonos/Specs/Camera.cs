using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone2Go.Telefonos.Specs
{
    class Camera : Tdecorator
    {
        public Camera(Itel itel) : base(itel)
        {
            this.m_name = "8mpx";
            this.m_price = 30;
        }
    }
    class camera12 : Tdecorator
    {
        public camera12(Itel itel) : base(itel)
        {
            this.m_name = "12mpx";
            this.m_price = 40;
        }
    }
    class camera16 : Tdecorator
    {
        public camera16(Itel itel) : base(itel)
        {
            this.m_name = "16mpx";
            this.m_price = 50;
        }
    }
}
