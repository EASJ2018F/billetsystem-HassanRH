using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class Bil:BasseKlasse
    {
        //public string Nummerplade
        //{
        //    get { return Nummerplade; }
        //}

        public override string Nummerplade
        {
            get { return Nummerplade; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Ugyldig Nummerplade, nummerplade må max have 7 tegn");

                }
                Nummerplade = value;
            }

        }

        public DateTime Dato
        {
            get { return Dato; }
        }


        //Metode
        public  int Pris()
        {
            if(Brobizz == true)
            {
                return 240 / 100 * 95;
            }
            return 240;
        }
        //Metode
        public  string køretøj()
        {
            return "Bil";
        }


    }
}
