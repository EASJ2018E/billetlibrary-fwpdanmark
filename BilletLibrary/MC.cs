﻿using System;
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
        public override decimal Pris()
        {
            return 125;
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