﻿using System;
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

        public ModelloEvento(String nome)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome;
            _voci = new List<Voce>();
        }

        public string nome
        {
            get
            {
                return _nome;
            }
        }

        public List<Voce> voci
        {
            get
            {
                return _voci;
            }
        }
    }
}