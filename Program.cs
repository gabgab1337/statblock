using System;

namespace RPG.StatBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            Console.WriteLine("Hello, World!");
            character.stats.PrintStats();
        }
    }
}
