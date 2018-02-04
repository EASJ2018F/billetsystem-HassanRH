using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class Bil
    {
        public string Nummerplade
        {
            get { return Nummerplade; }
        }

        public DateTime Dato
        {
            get { return Dato; }
        }

        public override int Pris()
        {
            return 240;
        }

        public override string køretøj()
        {
            return "Bil";
        }


    }
}
