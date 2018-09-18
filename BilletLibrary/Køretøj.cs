using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {

        public string NummerPlade { get; set; }

        public DateTime Dato { get; set; }

        public virtual decimal Pris()
        {
            return 0;
        }

        public virtual string Køretøjet()
        {
            return "";
        }


    }
}
