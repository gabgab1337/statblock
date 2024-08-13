using System;

namespace RPG.StatBlock{
    class Weapon : Action{
        private string weaponName = "weapon";
        private int diceType;
        private int diceAmount;
        private int modifier;
        private string? type;
        private string? damage;
        private int range;
        private int reach;
        private string skill = "strength";
        private string attributes = "";

        public Weapon(string weaponName, string desc, int diceType, int diceAmount, int modifier, string type, string damage, int range, int reach, string skill, string attributes){
            this.weaponName = weaponName;
            Description = desc;
            this.diceType = diceType;
            this.diceAmount = diceAmount;
            this.modifier = modifier;
            this.type = type;
            this.damage = damage;
            this.range = range;
            this.reach = reach;
            this.skill = skill;
            this.attributes = attributes;
        }

        public void setModifier(Dictionary<string, int> stats){ // not taking proficiency into account
            modifier = stats[skill];
        }
    }
}