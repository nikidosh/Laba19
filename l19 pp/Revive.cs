using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Revive:Spell
    {
        public override string ToString()
        {
            return "Оживить";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            a.State = "Здоров";
            a.State = "Здоров";
            minMana -= 150;
            a.HP = 1;
            a.HP = 2;
        }
    }
}
