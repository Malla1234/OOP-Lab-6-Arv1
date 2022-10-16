using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    
    class Hund : Djur //inheritance from Djur
    {
        public int Height;
        public Hund(string Name = "Olle", string Gender = "Hona", string Color = "Vit", int Age = 8, int Weight = 7, int Height = 5) //:base()
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
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
            Console.WriteLine("Voff");
        }
        public void dogJump()
        {
            Console.WriteLine("Hunden hoppar");
        }
    }
}
