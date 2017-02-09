using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (collection)
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person { FirstName = "Risto", LastName = "Matrirka", SocialSecurityNumber = "1234867-545A"};
            Person person2 = new Person { FirstName = "Isto", LastName = "Hillevi", SocialSecurityNumber = "13254-asd" };
            Person person3 = new Person { FirstName = "Riitta", LastName = "Kalevi", SocialSecurityNumber = "7895-45S"};

            // add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person
            Person person4 = myFriends.GetPerson(3);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("There is no person at that position!");
            }
            // print collection
            myFriends.Printdata();

            // find person
            string socialSecurityNumber = "13254-asd";
            Console.WriteLine("Find person with ssn: " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Can't find person with that ssn");
            }
        }
    }
}
