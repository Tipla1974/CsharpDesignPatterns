using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace CsharpDesignPatternsOefeningen
{
    public class SpeelgoedFactory
    {
        public  Speelgoed KiesSpeelgoed(int Leeftijd)
        {
            if (Leeftijd < 6)
            {
                return new Pop(15m);
            }
            else if (Leeftijd < 13)
            {
                return new Gezelschapsspel(25m);
            }
            else
            {
                return new Boekenbon(27m);
            }
        }
    }

    public abstract class Speelgoed
    {
        public decimal Prijs { get; set; }
        protected Speelgoed(decimal prijs)
        {
            Prijs = prijs;
        }
    }

    public class Pop : Speelgoed
    {
        public Pop(decimal prijs) :base(prijs) { }
    }
    public class Gezelschapsspel : Speelgoed
    {
        public Gezelschapsspel(decimal prijs) :base(prijs) { }
    }
    public class Boekenbon : Speelgoed
    {
        public Boekenbon(decimal prijs) : base(prijs) { }
    }
}
