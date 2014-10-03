using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    class ModelloEvento
    {
        private string _nome;
        private List<Voce> _voci;

        public ModelloEvento(string nome) : this(nome, new List<Voce>()) { }

        public ModelloEvento(string nome, List<Voce> voci)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome.Trim();
            _voci = (voci == null ? new List<Voce>() : voci);
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public List<Voce> Voci
        {
            get
            {
                return _voci;
            }
        }

        public void AggiungiVoce(Voce voce)
        {
            #region Precondizioni
            Debug.Assert(voce != null, "Voce cannot be null");
            #endregion

            _voci.Add(voce);
        }
    }
}
