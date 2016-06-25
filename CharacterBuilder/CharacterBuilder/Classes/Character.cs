using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Classes
{
    public class Character : Class
    {
        public string Name;
        public double Level;

        private int BaseStr;
        private int BaseDex;
        private int BaseCon;
        private int BaseQui;
        private int BasePie;
        private int BaseInt;
        private int BaseEmp;
        private int BaseCha;
        private int BonusStats = 30;

        public enum Realm
        {
            Albion,
            Midgard,
            Hibernia
        };
        public enum Race
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

        public Character()
        {
            var selectedRace = new Race();

            switch (selectedRace)
            {

                #region Albion
                case Race.Avalonian:
                    BaseStr = 45;
                    BaseCon = 45;
                    BaseDex = 60;
                    BaseQui = 70;
                    BaseInt = 80;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Briton:
                    BaseStr = 60;
                    BaseCon = 60;
                    BaseDex = 60;
                    BaseQui = 60;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Highlander:
                    BaseStr = 70;
                    BaseCon = 70;
                    BaseDex = 50;
                    BaseQui = 50;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Inconnu:
                    BaseStr = 50;
                    BaseCon = 60;
                    BaseDex = 70;
                    BaseQui = 50;
                    BaseInt = 70;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Saracen:
                    BaseStr = 50;
                    BaseCon = 50;
                    BaseDex = 80;
                    BaseQui = 60;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;
                #endregion

                #region Hibernia
                case Race.Celt:
                    BaseStr = 60;
                    BaseCon = 60;
                    BaseDex = 60;
                    BaseQui = 60;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Firbolg:
                    BaseStr = 90;
                    BaseCon = 60;
                    BaseDex = 40;
                    BaseQui = 40;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 70;
                    BaseCha = 60;
                    break;

                case Race.Lurikeen:
                    BaseStr = 40;
                    BaseCon = 40;
                    BaseDex = 80;
                    BaseQui = 80;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Sylvan:
                    BaseStr = 70;
                    BaseCon = 60;
                    BaseDex = 55;
                    BaseQui = 45;
                    BaseInt = 70;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Elf:
                    BaseStr = 40;
                    BaseCon = 40;
                    BaseDex = 75;
                    BaseQui = 75;
                    BaseInt = 70;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;
                #endregion

                #region Midgard
                case Race.Norseman:
                    BaseStr = 70;
                    BaseCon = 70;
                    BaseDex = 50;
                    BaseQui = 50;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Kobold:
                    BaseStr = 50;
                    BaseCon = 50;
                    BaseDex = 70;
                    BaseQui = 70;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Troll:
                    BaseStr = 100;
                    BaseCon = 70;
                    BaseDex = 35;
                    BaseQui = 35;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Valkyn:
                    BaseStr = 55;
                    BaseCon = 45;
                    BaseDex = 65;
                    BaseQui = 75;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;

                case Race.Dwarf:
                    BaseStr = 60;
                    BaseCon = 80;
                    BaseDex = 50;
                    BaseQui = 50;
                    BaseInt = 60;
                    BasePie = 60;
                    BaseEmp = 60;
                    BaseCha = 60;
                    break;
                #endregion

                default:
                    BaseStr = 0;
                    BaseCon = 0;
                    BaseDex = 0;
                    BaseQui = 0;
                    BaseInt = 0;
                    BasePie = 0;
                    BaseEmp = 0;
                    BaseCha = 0;
                    break;

            }
        }

        private int CalculateSpecializationPoints()
        {
            return 0;
        }

    }
}
