using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Filtros
{
    interface Ifiltros
    {
        void tabla(DataGridView dgv);
        void filtro(DataGridView dgv, string filtros);
    }
}
