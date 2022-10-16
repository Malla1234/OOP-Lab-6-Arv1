using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    class Pudel : Hund //inheritance from Hund
    {
        public string curlyFur;
        public Pudel(string Name = "Macke", string Gender = "Hane", string Color = "Grå", int Age = 7, int Weight = 6, int Height = 10, string curlyFur = "Ja") //:base()
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
            this.curlyFur = curlyFur;
        }
        public void animalWalk()
        {
            Console.WriteLine("Djuret går");
        }
        public void animalEat()
        {
            Console.WriteLine("Djuret äter");
        }
        public override void makeSound()
        {
            Console.WriteLine("Viiiooff");
        }
        public void dogJump()
        {
            Console.WriteLine("Hunden hoppar");
        }
        public void rollAround()
        {
            Console.WriteLine("Hunden rullar runt");
        }
    }
}
