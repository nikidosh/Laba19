using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class AddHp : Spell
    {
        public override string ToString()
        {
            return "Добавить хп";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            Console.WriteLine("Введите колличество хп");
            int countofHP = Convert.ToInt32(Console.ReadLine());
            a.HP += countofHP;
            a.Maxhp += countofHP;
        }
    }
}
