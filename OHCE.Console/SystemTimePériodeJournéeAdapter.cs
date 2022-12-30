using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHCE;

namespace OHCE.Console
{
    public class SystemTimePériodeJournéeAdapter 
    {
        public static PériodeJournée PériodeActuelle()
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
            {
                return PériodeJournée.Matin;
            }
            else if (DateTime.Now.Hour < 19)
            {
                return PériodeJournée.AprèsMidi;
            }
            else if (DateTime.Now.Hour < 22)
            {
                return PériodeJournée.Soir;
            }
            else
            {
                return PériodeJournée.Nuit;
            }
        }
    }
}
