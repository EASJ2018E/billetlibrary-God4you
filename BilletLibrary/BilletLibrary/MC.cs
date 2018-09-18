using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : BaseClass
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Fast pris 125kr
        /// </summary>
        /// <returns> decimal 125kr </returns>
        public override decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Returnere Køretøj i string
        /// </summary>
        /// <returns>String "MC"</returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
