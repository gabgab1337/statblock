using System;

namespace RPG.StatBlock{
    public class Stats{
        private int strength = 10, dexterity = 10, constitution = 10, inteligence = 10, wisdom = 10, charisma = 10;
        private int armorClass = 10;
        private int initiative = 0;
        private int speed = 30;
        private int hitPoints = 1;

        public int mod(int stat){
            return (stat - 10) / 2;
        }

        public int Strength{
            get { return strength; }
            set { strength = value; }
        }

        public int Dexterity{
            get { return dexterity; }
            set { dexterity = value; }
        }

        public int Constitution{ 
            get { return constitution; } 
            set { constitution = value; }
        }

        public int Inteligence{
            get { return inteligence; }
            set { inteligence = value; }
        }

        public int Wisdom{
            get { return wisdom; }
            set { wisdom = value; }
        }

        public int Charisma{
            get { return charisma; }
            set { charisma = value; }
        }

        public int ArmorClass{
            get { return armorClass; }
            set { armorClass = value; }
        }

        public int Initiative{
            get { return initiative; }
            set { initiative = value; }
        }

        public int Speed{
            get { return speed; }
            set { speed = value; }
        }

        public int HitPoints{
            get { return hitPoints; }
            set { hitPoints = value; }
        }

        public void PrintStats(){
            Console.WriteLine("--- Stats ---");
            Console.WriteLine($"Strength: {strength} ({mod(strength)})");
            Console.WriteLine($"Dexterity: {dexterity} ({mod(dexterity)})");
            Console.WriteLine($"Constitution: {constitution} ({mod(constitution)})");
            Console.WriteLine($"Inteligence: {inteligence} ({mod(inteligence)})");
            Console.WriteLine($"Wisdom: {wisdom} ({mod(wisdom)})");
            Console.WriteLine($"Charisma: {charisma} ({mod(charisma)})");
            Console.WriteLine($"Armor Class: {armorClass}");
            Console.WriteLine($"Initiative: {initiative}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Hit Points: {hitPoints}");
        }

    }
}