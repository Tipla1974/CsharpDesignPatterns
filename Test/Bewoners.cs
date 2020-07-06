using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{

    public abstract class Bewoners :IBewoners
    { 

        public Bewoners(string naam)
        {
            Naam = naam;
        }
        public string Naam { get; set; }

        public static void ReactieBijUitbarsting(Bewoners[] bewoners)
        {

        }
        public virtual void Afbeelden() { }
    }
}
