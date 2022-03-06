using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljka
{
    class Biljka
    {

    }
    class Stablo : Biljka
    {
        bool otpadajuListovi;

        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
    }
    class Cvijet : Biljka
    {

    }
    class Crnogoricno : Stablo
    {
        
    }
    class Bijelogoricno : Stablo
    {
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
