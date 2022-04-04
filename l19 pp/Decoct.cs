using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Decoct : Artifact
    {
        public Decoct() : base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Посох молния";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
                a.State = "здоров";
        }
    }
}
