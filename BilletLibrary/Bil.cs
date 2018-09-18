﻿using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {

       
        /// <summary>
        /// Retunerer pris som i denne er 240
        /// </summary>
        /// <returns></returns>
        
        public override decimal Pris()
        {
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
