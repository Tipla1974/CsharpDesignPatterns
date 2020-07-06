using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    public class VulkaanActief
    {
        public void DataInlezen()
        {
            BewonersFactory invoegenBewoners = new BewonersFactory();
            IBewoners[] bewoner = new IBewoners[20];
            string locatie = @"c:\test\vulkaan.txt";
            int teller = 0;
            try
            {
                string regel;
                using var lezer = new StreamReader(locatie);

                while ((regel = lezer.ReadLine()) != null)
                {
                    char dier = regel[0];
                    string naamDier = regel.Substring(1);
                    char soortDier = char.ToUpper(dier);
                    bewoner[teller] = invoegenBewoners.Add(soortDier, naamDier);

                    teller += 1;
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij het lezen van het bestand!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach(IBewoners item in bewoner)
            {
                if(item!= null)
                item.Afbeelden();
            }

        }
    }
}
