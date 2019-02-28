using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Filtros
{
    class Baterias : Ifiltros
    {
        Sqlite s = new Sqlite();
        public void filtro(DataGridView dgv,string type)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tipo] LIKE '%{0}%'", type);
        }

        public void tabla(DataGridView dgv)
        {
            throw new NotImplementedException();
        }
    }
}
