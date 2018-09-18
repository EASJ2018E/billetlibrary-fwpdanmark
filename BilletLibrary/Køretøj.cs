using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private string _nummerPlade;

        public string NummerPlade
        {
            get => _nummerPlade;
            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("Længde af nummerplade for lang");
                }
                else
                {
                    _nummerPlade = value;
                }
                
            }
        }

        public DateTime Dato { get; set; }

        public virtual decimal Pris(bool brobizz)
        {
            return 0;
        }

        public virtual string Køretøjet()
        {
            return "";
        }


    }
}
