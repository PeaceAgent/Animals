using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : DomesticMammal
    {
        protected override int NumberofLegs { get { return 4; } }
        public virtual string Breed { get { return "Just a dog"; } }
        public virtual string BreedFamily { get { return "Dog"; } }

        private void Init ()
        {
            Console.WriteLine("Dog created");
        }
        public Dog(string name, int age, string favoriteToy, bool isPregnant) : base(name, age, favoriteToy, isPregnant)
        { 
            this.Init();

        }
        
        public Dog(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        { 
            this.Init();

        }
        public void PrintBreedFamily()
        {
            Console.WriteLine(this.BreedFamily);
        }
    }
}
