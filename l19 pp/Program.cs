using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Program
    {
        static void Main(string[] args)
        {
           Character obj1 = new Character("ak", "Живой", true, true, "Tdoll", "ж", 22, 2000, 350000, 2200);
            Console.WriteLine(obj1);
            obj1.addArtifact();
            obj1.PrintContents();
            //obj1.DelArtifact();
            obj1.Use();
            Console.WriteLine(obj1);
            Console.ReadLine();
            Caster obj2 = new Caster(2000,1500,"ak12", "Живой", true, true, "Tdoll", "ж", 21, 2000, 350000, 2200);

            obj2.addSpell();
            obj2.PrintListOfSpells();
            obj2.UseSpell();
            Console.WriteLine(obj2);
            Console.ReadKey();
        }
    }
}
