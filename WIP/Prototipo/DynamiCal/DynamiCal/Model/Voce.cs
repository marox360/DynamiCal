﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace DynamiCal.Model
{
    class Voce
    {
        public enum Tipo
        {
            [Description("Testo")]
            Stringa,
            [Description("Numero")]
            Double,
            [Description("Sì/No")]
            Boolean,
            [Description("Data")]
            Data
        };

        public Voce(string nome, Tipo tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            this.Nome = nome.Trim();
            this.TipoVoce = tipo;
        }

        public string Nome { get; private set; }

        public Tipo TipoVoce { get; private set; }
    }

    interface IVoce
    {
        string Nome { get; }

        object Valore { get; set; }
    }

    class Voce<T> : IVoce
    {
        public Voce(string nome) : this(nome, default(T)) { }

        public Voce(string nome, T valore)
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            this.Valore = valore;
            this.Nome = nome;
        }

        public string Nome { get; private set; }

        public T Valore { get; set; }

        object IVoce.Valore
        {
            get
            {
                return this.Valore;
            }
            set
            {
                if (value is T)
                {
                    this.Valore = (T)value;
                }
            }
        }
    }
}
