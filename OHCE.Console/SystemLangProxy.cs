using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OHCE.Console
{
    public class SystemLangProxy
    {
        public static ILangue SystemLangProxyGetLang()
        {
            ILangue Langue;

            switch (CultureInfo.InstalledUICulture.TwoLetterISOLanguageName)
            {
                case "fr":
                    Langue = new Langues.LangueFrançaise();
                    break;

                case "en":
                    Langue = new Langues.LangueAnglaise();
                    break;

                default:
                    Langue = new Langues.LangueAnglaise();
                    break;
            }

            return Langue;
        }
    }
}
