using System;
using System.Runtime.CompilerServices;

namespace RPG.StatBlock
{
    public class Character
    {
        private string name = "John Doe";
        private string specie = "Human";
        private int challenge = 0;
        private string type = "Humanoid";
        private string size = "Medium";

        public Stats stats = new Stats();

        public void PrintCharacter(){
            Console.WriteLine(name);
            Console.WriteLine($"{size} {type}");
            stats.PrintStats();
        }

        public string Name{
            get { return name; }
            set { name = value; }
        }

        public string Specie{
            get { return specie; }
            set { specie = value; }
        }

        public int Challenge{
            get { return challenge; }
            set { challenge = value; }
        }

        public string Type{
            get { return type; }
            set { type = value; }
        }

        public string Size{
            get { return size; }
            set { size = value; }
        }
    }
}