using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class MC:BasseKlasse
    {
        //Propertie
        public string Nummerplade
        {
            get { return Nummerplade; }
        }
        //Propertie
        public DateTime Dato
        {
            get { return Dato; }
        }
        //Metode
        public  int Pris()
        {
            if (Brobizz == true)
            {
                return (125 / 100 * 95);
            }
            return 125;
        }
        //Metode
        public  string køretøj()
        {
            return "MC";
        }


    }
}
