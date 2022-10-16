using System;

namespace OOP_Lab_6___Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur djur = new Djur();
            djur.makeSound();

            Hund hund = new Hund();
            hund.makeSound();

            Katt katt = new Katt();
            katt.makeSound();

            Häst häst = new Häst();
            häst.makeSound();

            Pudel pudel = new Pudel();
            pudel.makeSound();

            Bulldog bulldog = new Bulldog();
            bulldog.makeSound();

            Console.ReadLine();
            
        }
    }
}