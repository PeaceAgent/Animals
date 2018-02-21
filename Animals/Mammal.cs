using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Mammal: Animal
    {
        protected override int PairsofEyes { get { return 1; } }
        public bool isPregnant { get; set; }
        private void Init(bool isPregnant)
        {
            this.isPregnant = isPregnant;
            Console.WriteLine("Mammal created.");

        }

        public Mammal(int age ) : base(age)
        {
            this.Init(false);
        }

        public Mammal(int age, bool isPregnant) :base(age)
        {
            this.Init(isPregnant);
        }
    }
}
