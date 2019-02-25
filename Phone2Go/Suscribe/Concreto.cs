using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Phone2Go.Suscribe
{
    class Concreto : Observer
    {
        private string _name;
        private string _Estado;
        private SujetoConcreto _sujeto;

        public Concreto(string name, SujetoConcreto sujeto)
        {
            _name = name;
          
            _sujeto = sujeto;
        }

        public override void Update()
        {

            _Estado = _sujeto.Estado;
            MessageBox.Show("El usuario "+_name,_Estado);
        }
        public SujetoConcreto Sujeto
        {
            get { return _sujeto; }
            set { _sujeto = value; }
        }
    }
}
