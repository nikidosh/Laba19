using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Protivo9die:Spell
    {
        public override string ToString()
        {
            return "Противоядие";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            a.State = "Здоров";
            a.State = "Здоров";
            minMana -= 30;
        }
    }
}
