using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Peppa", 4, "Fluffy Bear");
            Dog myOtherDog = new Dog("Preggo Peppa", 5, "Jack", true);
            Console.WriteLine("It worked, congrats :) ");
            Console.WriteLine("GitHub problems are solved");
            Console.WriteLine("GitHub problem is not solved");
            Console.ReadLine();
        }
    }
}
