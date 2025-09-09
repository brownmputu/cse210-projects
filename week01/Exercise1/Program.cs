using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("a cofee,thee,rise,fufu,bean,fish,cheeken,duck,beef");

        Console.WriteLine("what are you gonna cook this morning?");
        string morning = Console.ReadLine();

        Console.WriteLine("what are you gonna cook this afterNoon?");
        string afterNoon = Console.ReadLine();

        Console.WriteLine("what are you gonna cook this evening?");
        string evening = Console.ReadLine();

        Console.WriteLine($"today you will eat :{morning} and {afterNoon} and {evening}");
    }
}