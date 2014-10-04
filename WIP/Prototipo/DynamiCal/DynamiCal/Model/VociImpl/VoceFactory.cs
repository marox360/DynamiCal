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
            switch (voce.Tipo.Tipo)
            {
                case TipoVoce.Type.Stringa:
                    return new VoceStringa(voce.Nome, voce.Tipo);

                case TipoVoce.Type.Double:
                    return new VoceDouble(voce.Nome, voce.Tipo);

                case TipoVoce.Type.Boolean:
                    return new VoceBoolean(voce.Nome, voce.Tipo);

                case TipoVoce.Type.Data:
                    return new VoceData(voce.Nome, voce.Tipo);

                default:
                    return null;
            }
        }
    }
}
