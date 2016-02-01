using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        public int Maa { get; set; }
        public int Nro { get; set; }

        public override string ToString()
        {
            return Maa + " " + Nro;
        }
    }
}
