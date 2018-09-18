using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
   public abstract class BaseClass
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// metode signator med pris
        /// </summary>
        public abstract decimal Pris();


        /// <summary>
        /// Metode signator med string køretøj
        /// </summary>
        public abstract string Køretøj();

    }
}

