using System;

namespace CsharpDesignPatternsOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeelgoedFactory factory = new SpeelgoedFactory();
            Speelgoed speelgoed = factory.KiesSpeelgoed(15);
            Console.WriteLine(speelgoed.Prijs);
        }
    }
}
