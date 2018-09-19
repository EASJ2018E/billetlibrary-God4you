using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
   public abstract class BaseClass
    {
        private string _nummerplade;

        //public string nummerPlade;
        /// <summary>
        /// Nummerplade må ikke inholde mere end 7 tal.
        /// </summary>
        public string Nummerplade
        {
            get => _nummerplade;
            set {
                if (value.Length >=1 && value.Length <=7)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new ArgumentException("For mange tal");
                }
               
                }
        }

        public virtual DateTime Dato { get; set; }
        public decimal Rabat = 0.05m;
        /// <summary>
        /// metode signator med pris
        /// </summary>
        public abstract decimal Pris();

        /// <summary>
        /// CalcBrobizz tager prisen for en method og en true / false.
        /// </summary>
        /// <param name="brug din pris method her. Ex, Bil.Pris()"></param>
        /// <param name="Brobizz. Bool. bruge True or False"></param>
        /// <returns>Prise efter rabat</returns>
        public decimal CalcBrobizz(decimal pris, bool Brobizz)
        {
            if (Brobizz) //Hvis Brobizz er true så gangen prisen med rabatten 0.05
            {
                return pris * Rabat;
            }
            else
            {
                return pris;
            }
            
        }
        /// <summary>
        /// Metode signator med string køretøj
        /// </summary>
        public abstract string Køretøj();

    }
}

