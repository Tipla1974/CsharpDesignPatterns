using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var deVulkaan = Vulkaan.GetInstance();

            deVulkaan.Rust();
            deVulkaan.Uitbarsting();
            deVulkaan.Rust();
        }
    }
}
