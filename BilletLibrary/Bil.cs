using System;

namespace BilletLibrary
{
    public class Bil
    {

        public string NummerPlade { get; set; }

        public DateTime Dato { get; set; }
        /// <summary>
        /// Retunerer pris som i denne er 240
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Returnerer køretøjtype som i denne er Bil
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "Bil";
        }

    }
}
