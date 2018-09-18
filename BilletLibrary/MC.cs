using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        
        /// <summary>
        /// Returnerer pris i dette tilfælde 125
        /// </summary>
        /// <returns></returns>
        public override decimal Pris(bool brobizz)
        {
            if (brobizz)
            {
                decimal sum = (125m/100m)*95m;
                return sum;
            }
            return 125m;
        }
        /// <summary>
        /// Returnerer Køretøj i dette tilfæde "MC"
        /// </summary>
        /// <returns></returns>
        public override string Køretøjet()
        {
            return "MC";
        }

    }
}
