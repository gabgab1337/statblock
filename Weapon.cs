using System;

namespace RPG.StatBlock{
    public class Weapon : Action{
        private string[] weapons = {
            "club",
            "dagger",
            "shortbow",
            "greatsword",
            "warhammer",
            "longbow"
        };
        private Dictionary<string, int[]> weaponDamage = new Dictionary<string, int[]>{
            {"club", new int[] {1, 4}},
            {"dagger", new int[] {1, 4}},
            {"shortbow", new int[] {1, 6}},
            {"greatsword", new int[] {2, 6}},
            {"warhammer", new int[] {1, 8}},
            {"longbow", new int[] {1, 8}}
        }; //{weapon, [diceAmount, diceType]}
        private Dictionary<string, string> weaponType = new Dictionary<string, string>{
            {"club", "bludgeoning"},
            {"dagger", "piercing"},
            {"shortbow", "piercing"},
            {"greatsword", "slashing"},
            {"warhammer", "bludgeoning"},
            {"longbow", "piercing"}
        };
        private Dictionary<string, int> weaponRange = new Dictionary<string, int>{
            {"club", 5},
            {"dagger", 20},
            {"shortbow", 80},
            {"greatsword", 0},
            {"warhammer", 0},
            {"longbow", 150}
        };
        private Dictionary<string, int> weaponReach = new Dictionary<string, int>{
            {"club", 5},
            {"dagger", 5},
            {"shortbow", 0},
            {"greatsword", 5},
            {"warhammer", 5},
            {"longbow", 0}
        };
        private Dictionary<string, string> weaponSkill = new Dictionary<string, string>{
            {"club", "strength"},
            {"dagger", "finesse"},
            {"shortbow", "dexterity"},
            {"greatsword", "strength"},
            {"warhammer", "strength"},
            {"longbow", "dexterity"}
        };


        private string weaponName = "weapon";
        private int diceType;
        private int diceAmount;
        private int modifier;
        private string? type;
        private int range;
        private int reach;
        private string skill = "strength";
        private string attributes = "";

        public Weapon(string weaponName){
            this.weaponName = weaponName;
            if (weapons.Contains(weaponName)){
                diceAmount = weaponDamage[weaponName][0];
                diceType = weaponDamage[weaponName][1];
                type = weaponType[weaponName];
                range = weaponRange[weaponName];
                reach = weaponReach[weaponName];
                skill = weaponSkill[weaponName];
            }else{
                throw new Exception("Weapon not found");
            }
            modifier = setModifier(skill); 
        }

        public int setModifier(string skill){ // not taking proficiency into account
            if (skill == "finesse"){

            }else{
                
            }
            return 0;
        }
    }
}