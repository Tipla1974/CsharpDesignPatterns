using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Vulkaan
    {
        private static Vulkaan _uniekeInstantie;

        private bool uitbarsting;

        private Vulkaan() { }

        public static Vulkaan GetInstance()
        {
            if (_uniekeInstantie == null)
            {
                _uniekeInstantie = new Vulkaan();
            }
            return _uniekeInstantie;
        }

        public void Uitbarsting()
        {
            if (!uitbarsting)
            {
                uitbarsting = true;
                VulkaanActief vulkaanActief = new VulkaanActief();
                vulkaanActief.DataInlezen();
            }                
        }
        public void Rust()
        {
            if (uitbarsting)
            {
                uitbarsting = false;
            }
        }
            
    }
}
