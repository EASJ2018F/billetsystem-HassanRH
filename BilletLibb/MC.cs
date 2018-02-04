using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class MC
    {
        public string Nummerplade
        {
            get { return Nummerplade; }
        }
        public DateTime Dato
        {
            get { return Dato; }
        }

        public int Pris()
        {
            return 125;
        }
        public string Køretøj()
        {
            return "MC";
        }


    }
}
