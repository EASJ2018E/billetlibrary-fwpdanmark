using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {

       
        /// <summary>
        /// Retunerer pris som i denne er 240
        /// </summary>
        /// <returns></returns>
        
        public override decimal Pris(bool brobizz)
        {
            if (brobizz)
            {
                decimal sum = (240 / 100) * 95;
                return sum;
            }
            return 240;
        }
        /// <summary>
        /// Returnerer køretøjtype som i denne er Bil
        /// </summary>
        /// <returns></returns>
        public override string Køretøjet()
        {
            return "Bil";
        }

        
    }
}
