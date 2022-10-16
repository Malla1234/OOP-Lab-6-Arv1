using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    class Bulldog : Hund ////inheritance from Hund
    {
        public string looseSkin;
        public Bulldog(string Name = "Nisse", string Gender = "Hane", string Color = "Silver", int Age = 2, int Weight = 6, int Height = 30, string looseSkin = "Ja") //:base()
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
            this.looseSkin = looseSkin;
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
            Console.WriteLine("slaffs voff");
        }
        public void dogJump()
        {
            Console.WriteLine("Hunden hoppar");
        }
        public void dogSit()
        {
            Console.WriteLine("Hunden sitter");
        }
    }
}
