using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Køretøjer
    {
        /// <summary>
        /// Brobizz er true, det ville være godt at få en konstructor så du ville kunne bruge den.
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            int Price = 125;
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
            return "MC";
        }

        
    }
}
