﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DynamiCal.Model
{
    public struct Periodicita
    {
        public enum Frequenza
        {
            Mai = 0, Giornaliera, Settimanale, Mensile, Annuale
        }

        private int _valore;
        private Frequenza _frequenza;

        public Periodicita(Frequenza frequenza, int valore = 1)
        {
            #region Precondizioni
            Debug.Assert(valore >= 1, "Valore can't be zero or negative");
            #endregion

            _valore = valore;
            _frequenza = frequenza;
        }

        public static Periodicita Mai
        {
            get
            {
                return new Periodicita(Frequenza.Mai);
            }
        }

        public static Periodicita Giornaliera
        {
            get
            {
                return new Periodicita(Frequenza.Giornaliera);
            }
        }

        public static Periodicita Settimanale
        {
            get
            {
                return new Periodicita(Frequenza.Settimanale);
            }
        }

        public static Periodicita Mensile
        {
            get
            {
                return new Periodicita(Frequenza.Mensile);
            }
        }

        public static Periodicita Annuale
        {
            get
            {
                return new Periodicita(Frequenza.Annuale);
            }
        }

        public int Valore
        {
            get
            {
                return _valore;
            }
            set
            {
                #region Precondizioni
                Debug.Assert(value >= 1, "Valore can't be zero or negative");
                #endregion

                _valore = value;
            }
        }

        public Frequenza Ripetizione
        {
            get
            {
                return _frequenza;
            }
            set
            {
                _frequenza = value;
            }
        }

        public static Periodicita operator *(Periodicita periodicita, int valore)
        {
            return new Periodicita(periodicita.Ripetizione, valore);
        }
    }
}
