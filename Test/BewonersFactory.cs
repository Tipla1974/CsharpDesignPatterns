using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class BewonersFactory
    {
        public Bewoners Add(char soortDier, string naamDier)
        {
            

            switch (soortDier)
            {
                case 'V':
                    return new Vogels(naamDier);
                    
                case 'Z':
                    return new Zoogdieren(naamDier);
                    
                default:
                    throw new Exception($"Onbekende Diersoort {soortDier}");
            }
        }
      
    }
}
