using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Indholder properties nummerplade og Dato. 
    /// Indholder metoden Pris og Køretøj.
    /// </summary>
    public class Bil : BaseClass
    {
        /// <summary>
        /// Fast pris 240kr
        /// </summary>
        /// <returns> decimal 240kr </returns>
        public override decimal Pris()
        {
               return 240;
            
        }
        /// <summary>
        /// Returnere Bil i string
        /// </summary>
        /// <returns>String "Bil"</returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
