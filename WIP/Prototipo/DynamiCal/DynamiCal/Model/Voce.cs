﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection;

namespace DynamiCal.Model
{
    static class TipoVoceExtension
    {
        public static string GetDescription(this Voce.Tipo value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }
    }

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

        private readonly string _nome;
        private readonly Tipo _tipo;

        public Voce(string nome, Tipo tipo) 
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _nome = nome.Trim();
            _tipo = tipo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public Tipo TipoVoce
        {
            get
            {
                return _tipo;
            }
        }
    }

    interface IVoce
    {
        string Nome { get; }

        object Valore { get; set; }
    }

    class Voce<T> : IVoce
    {
        private readonly string _nome;
        private T _valore;

        public Voce(string nome, T valore = default(T))
        {
            #region Precondizioni
            Debug.Assert(!String.IsNullOrWhiteSpace(nome), "Nome is null or white space");
            #endregion

            _valore = valore;
            _nome = nome;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public T Valore
        {
            get
            {
                return _valore;
            }
            set
            {
                _valore = value;
            }
        }

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
