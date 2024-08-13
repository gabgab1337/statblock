using System;

namespace RPG.StatBlock{
    public class Stats{
        Dictionary<string, int> coreStats = new Dictionary<string, int> 
        {
            {"strength", 10}, 
            {"dexterity", 10}, 
            {"constitution", 10}, 
            {"inteligence", 10}, 
            {"wisdom", 10}, 
            {"charisma", 10}};
        private int armorClass = 10;
        private int initiative = 0;
        private int speed = 30;
        private int hitPoints = 1;

        public int mod(int stat){
            return (stat - 10) / 2;
        }

        public int strength{
            get { return coreStats["strength"]; }
            set { coreStats["strength"] = value; }
        }
        public int dexterity{
            get { return coreStats["dexterity"]; }
            set { coreStats["dexterity"] = value; }
        }
        public int constitution{
            get { return coreStats["constitution"]; }
            set { coreStats["constitution"] = value; }
        }
        public int inteligence{
            get { return coreStats["inteligence"]; }
            set { coreStats["inteligence"] = value; }
        }
        public int wisdom{
            get { return coreStats["wisdom"]; }
            set { coreStats["wisdom"] = value; }
        }
        public int charisma{
            get { return coreStats["charisma"]; }
            set { coreStats["charisma"] = value; }
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