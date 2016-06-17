using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Character
{
    class Char
    {
        public string strName;

        public enum enumRealm
        {
            Albion,
            Midgard,
            Hibernia
        };

        public enum enumRace
        {
            Briton,
            Avalonian,
            Highlander,
            Saracen,
            Inconnu,
            Celt,
            Firbolg,
            Lurikeen,
            Elf,
            Sylvan,
            Dwarf,
            Norseman,
            Troll,
            Kobold,
            Valkyn
        }

        public enum enumClass
        {
            Armsman,
            Paladin,
            Mercenary,
            Reaver,
            Friar,
            Cleric,
            Minstrel,
            Scout,
            Infiltrator,
            Sorcerer,
            Cabalist,
            Wizard,
            Theugist,
            Necromancer,
            Bard,
            Druid,
            Warden,
            Nightshade,
            Ranger,
            Hero,
            Blademaster,
            Champion,
            Eldritch,
            Enchanter,
            Mentalist,
            Animist,
            Valewalker,
            Thane,
            Warrior,
            Skald,
            Savage,
            Beserker,
            Shaman,
            Healer,
            Runemaster, 
            Bonedancer,
            Spiritmaster,
            Shadowblade,
            Hunter                
        }

        public double intLevel;

        public int intBaseStr;
        public int intBaseDex;
        public int intBaseCon;
        public int intBaseQui;
        public int intBasePie;
        public int intBaseInt;
        public int intBaseEmp;
        public int intBaseCha;
        public int intBonusStat;

        public double intSpecializationPoints;

        private void SetBaseStats()
        {

        }

        public void SetSpecializationPoints()
        {
            for (int i = 2; i<= intLevel; i++)
            {
                intSpecializationPoints += i;
            }
        }
    }
}
