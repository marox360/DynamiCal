using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model
{
    static class VoceFactory
    {
        public static Voce GetImplementedVoce(Voce voce)
        {
            switch (voce.Tipo.TipoDiVoce)
            {
                case TipoVoce.Tipo.Stringa:
                    return new Voce<string>(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Double:
                    return new Voce<double>(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Boolean:
                    return new Voce<bool>(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Data:
                    return new Voce<DateTime>(voce.Nome, voce.Tipo);

                default:
                    return null;
            }
        }
    }
}
