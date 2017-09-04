using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Køretøjer
    {

        public override int Pris()
        {
            int Price = 240;
            int Rabat;
            if (Brobizz = true)
            {
                Rabat = (Pris() / 100) * 5;
                return Pris() - Rabat;
            }
            return Price;
        }

        


        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
