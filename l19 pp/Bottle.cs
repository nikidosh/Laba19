using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Bottle:Artifact
    {
        public Bottle() : base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Бутылка с живой водой";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            while(a.HP<a.MaxHP)
            {
                a.HP++;
            }
        }
    }
}
