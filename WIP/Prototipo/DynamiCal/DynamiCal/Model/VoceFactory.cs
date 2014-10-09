using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    static class VoceFactory
    {
        public static IVoce GetImplementedVoce(Voce voce)
        {
            switch (voce.TipoVoce)
            {
                case Voce.Tipo.Stringa:
                    return new Voce<string>(voce.Nome);

                case Voce.Tipo.Double:
                    return new Voce<double>(voce.Nome);

                case Voce.Tipo.Boolean:
                    return new Voce<bool>(voce.Nome);

                case Voce.Tipo.Data:
                    return new Voce<DateTime>(voce.Nome);

                default:
                    return null;
            }
        }
    }
}
