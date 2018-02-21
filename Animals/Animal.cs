using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected virtual int NumberofLegs {
            get {
                return 0;
            }
        }

        protected virtual int  PairsofEyes { 
        
            get {
                return 0;
            }
        }

        public int Age { get; set; }

        public Animal (int age)
        {
            this.Age = age;
            Console.WriteLine("Animal created");
        }
        
        public void PrintLegsAndEyes()
        {
            Console.WriteLine(String.Format("I have {0} legs and {1} eyes", this.NumberofLegs, this.PairsofEyes * 2));
        }

        public void PrintAge()
        {
            Console.WriteLine(String.Format("I have {0} years old", this.Age));
        }

    }

}
