using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class DeadWater : Artifact
    {
        public DeadWater() : base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Бутылка с мертвой водой";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            while (a.HP < a.MaxHP)
            {
                a.HP--;
            }
        }
    }
}
