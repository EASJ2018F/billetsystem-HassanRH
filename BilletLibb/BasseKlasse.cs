using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class BasseKlasse
    {
        private string _nummerplade;
        private DateTime _dato;
        public bool Brobizz;


        public virtual string Nummerplade
        {
            get { return this._nummerplade; }
            set { _nummerplade = value; }
        }

        public virtual DateTime Dato
        {
            get { return this._dato; }
            set { _dato = value; }
        }


      


    }
}
