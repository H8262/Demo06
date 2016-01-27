using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD {Name = "The Mantle", Artist = "Agalloch" };

            Song song1 = new Song { Name = "Celebration of a death of a man..." };
            Song song2 = new Song { Name = "In the shadow of our pale companion" };

            cd.AddSong(song1);

        }
    }
}
