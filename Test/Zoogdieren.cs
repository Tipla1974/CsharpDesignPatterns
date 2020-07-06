using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Zoogdieren : Bewoners
    {
        public Zoogdieren(string naam)
           : base(naam) { }
        public override void Afbeelden()
        {
            Console.WriteLine($"Bewoner {Naam} gaat in zijn hol om te schuilen omdat hij een zoogdier is.");
        }
    }
}
