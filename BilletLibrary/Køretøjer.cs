using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class Køretøjer
    {
        
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public abstract int Pris();


        public virtual string Køretøj()
        {
            return "Bil";
        }

        public string nummerpladeLimit()
        {
            string nummerPlade = this.Nummerplade;
            if (nummerPlade.Length > 7)
            {
                throw new ArgumentException("Ugyldig nummerplade!");
            }
            return nummerPlade;
        }


    }
}
