using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.Model.VociImpl
{
    static class VoceFactory
    {
        static Voce GetImplementedVoce(Voce voce)
        {
            switch (voce.Tipo.TipoDiVoce)
            {
                case TipoVoce.Tipo.Stringa:
                    return new VoceStringa(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Double:
                    return new VoceDouble(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Boolean:
                    return new VoceBoolean(voce.Nome, voce.Tipo);

                case TipoVoce.Tipo.Data:
                    return new VoceData(voce.Nome, voce.Tipo);

                default:
                    return null;
            }
        }
    }
}
