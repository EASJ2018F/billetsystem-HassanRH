using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibb
{
    public class Bil:BasseCL
    {
        //public string Nummerplade
        //{
        //    get { return Nummerplade; }
        //}

        public virtual string Nummerplade
        {
            get { return Nummerplade; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("nummberpladen må max være 7 tegn");

                }
                Nummerplade = value;
            }
        }


        public DateTime Dato
        {
            get { return Dato; }
        }

        public  int Pris()
        {
            return 240;
        }

        public  string køretøj()
        {
            return "Bil";
        }


    }
}
