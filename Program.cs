using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Jenica = new Wizard("Jenica", 23, "Wizard White");
            Ninja  Wedge = new Ninja("Wedge", 42, "Ninja");


            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jenica.Attack(7));
            Console.WriteLine(Wedge.Attack());
        }
    }
}
