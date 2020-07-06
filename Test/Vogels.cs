using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Vogels : Bewoners
    {
        public Vogels(string naam)
            :base(naam) { }

        public override void Afbeelden()
        {
            Console.WriteLine($"Bewoner {Naam} gaat hoger op vliegen omdat hij een vogel is.");
        }
    }
}
