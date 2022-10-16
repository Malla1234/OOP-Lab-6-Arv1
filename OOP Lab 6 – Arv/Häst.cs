using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    class Häst : Djur //inheritance from Djur
    {
        public string tame;
        public Häst(string Name = "Frallan", string Gender = "Hona", string Color = "röd", int Age = 8, int Weight = 57, string tame = "ja") //:base()
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
            this.tame = tame;
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
            Console.WriteLine("Gnägg");
        }
        public void horseRun()
        {
            Console.WriteLine("Hästen springer");
        }
    }
}
