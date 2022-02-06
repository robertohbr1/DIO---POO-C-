using System;
using POO.src.Entities;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Mago openent = new Mago("Malvado", 88, "Devil");

            Console.WriteLine(hero);
            Console.WriteLine(openent.Attack(20));
        }
    }
}
