using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    class Katt : Djur //inheritance from Djur
    {
        public string vaccinated;
        public Katt(string Name = "Janne", string Gender = "Hane", string Color = "Brun", int Age = 2, int Weight = 7, string vaccinated = "Ja") //:base()
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
            this.vaccinated = vaccinated;
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
            Console.WriteLine("Mjao");
        }
        public void catSmell()
        {
            Console.WriteLine("Katten luktar");
        }
    }
}
