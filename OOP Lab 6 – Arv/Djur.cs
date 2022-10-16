using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_6___Arv
{
    //base class
    class Djur 
    {
        //fields
        public string Name;
        public string Gender;
        public string Color;
        public int Age;
        public int Weight;

       // constructor
      public Djur(string Name = "Djur", string Gender = "Hona/Hane", string Color = "Djurets färg", int Age = 0, int Weight = 0)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Color = Color;
            this.Age = Age;
            this.Weight = Weight;
        }

        //methods
        public void animalWalk()
        {
            Console.WriteLine("Djuret går");
        }
        public void animalEat()
        {
            Console.WriteLine("Djuret äter");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("Djuret säger");
        }
    }
}
