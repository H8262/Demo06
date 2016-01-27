using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myFriends = new Persons();

            // create friends...
            Person person1 = new Person { FirstName = "Marke", LastName = "Boy", SocialSecurityNumber = "010101" };
            Person person2 = new Person { FirstName = "Kalle", LastName = "Kekäle", SocialSecurityNumber = "020202" };
            Person person3 = new Person { FirstName = "Pekka", LastName = "Pökäle", SocialSecurityNumber = "030303" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //print collection
            myFriends.PrintCollection();

            //get one person
            Console.WriteLine("Get one person from collection: ");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            //find person with sotu
            string socialSecurityNumber = "010101";
            Console.WriteLine("Find person with sotu : " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found...");
            }
        }
    }
}
//stopwatch