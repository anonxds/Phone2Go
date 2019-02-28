using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone2Go.Suscribe
{
  abstract  class Sujeto
    {
        private List<Observer> _observers = new List<Observer>();

        public void Sub(Observer observer)
        {
            _observers.Add(observer);
        }
        public void unsub(int i)
        {
            _observers.RemoveAt(i);
            
        }
        public void Notifica(RichTextBox s)
        {
            foreach(Observer o in _observers)
            {
                o.Update(s);
            }
        }
        public void Populate(ComboBox cb)
        {
            cb.Items.Add(_observers);
        }
    }
    class SujetoConcreto : Sujeto
    {
        private string _EstadoSujeto;
        public string Estado
        {
            get { return _EstadoSujeto; }
            set { _EstadoSujeto = value; }
        }
    }
    
}
