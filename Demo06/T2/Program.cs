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

            Song song1 = new Song { Name = "A Celebration for the death of man...", Duration =  "2:24"};
            Song song2 = new Song { Name = "In the shadow of our pale companion", Duration = "14:44"};
            Song song3 = new Song { Name = "Odal", Duration = "7:38" };
            Song song4 = new Song { Name = "I am the wooden doors", Duration =  "6:10"};
            Song song5 = new Song { Name = "The Lodge", Duration = "4:39" };
            Song song6 = new Song { Name = "You were but a ghost in my arms", Duration = "9:13" };
            Song song7 = new Song { Name = "The Hawthrone passage", Duration = "11:17" };
            Song song8 = new Song { Name = "...And the great cold death of the earth", Duration = "7:13" };
            Song song9 = new Song { Name = "A Desolation song", Duration = "5:07" };

            cd.AddSong(song1);
            cd.AddSong(song2);
            cd.AddSong(song3);
            cd.AddSong(song4);
            cd.AddSong(song5);
            cd.AddSong(song6);
            cd.AddSong(song7);
            cd.AddSong(song8);
            cd.AddSong(song9);

            Console.WriteLine("Name: " + cd.Name + " Artist: " + cd.Artist);
            Console.WriteLine(song1.ToString());
            Console.WriteLine(song2.ToString());
            Console.WriteLine(song3.ToString());
            Console.WriteLine(song4.ToString());
            Console.WriteLine(song5.ToString());
            Console.WriteLine(song6.ToString());
            Console.WriteLine(song7.ToString());
            Console.WriteLine(song8.ToString());
            Console.WriteLine(song9.ToString());

        }
    }
}
