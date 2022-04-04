using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Caster:Character
    {
        public int Mana;
        public int MaxMana;
        public List<Spell> spells = new List<Spell>();
        public string spell = @"Введите номер заклинания:
            1-Поднять хп
            2-«Вылечить»
            3-«Противоядие»
            4-«Оживить»
            5-«Броня»
            6-«Отомри!»";

        public Caster(int nMaxMana,int nMana,string newName, string newState, bool CanTalk, bool CanValk, string newRace, string newGender, int nAge, int nHp, int nExp, int nMaxH):base(newName, newState,CanTalk,CanValk,newRace,newGender,nAge,nHp,nExp,nMaxH)
        {
            Mana = nMana;
            MaxMana = nMaxMana;
        }
       
        public void ChangeMana(int countOfneededmana)
        {
            if(countOfneededmana>Mana)
            { Console.WriteLine("Ошибка"); }
            else
            { Mana -= countOfneededmana; }
        }
        public void CastStrrenght(int strength)
        {
            if(strength>Mana)
            {
                Console.WriteLine("");
            }
            else
            {
                Mana -= strength;
            }
        }
        public void addSpell()
        {
            Console.WriteLine("Каждое заклинание можно добавить только один раз");
            Console.WriteLine(spell);
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    {
                        AddHp obj1 = new AddHp();
                        spells.Add(obj1);
                        spell.Replace("1-Поднять хп"," ");
                        break;
                    }
                case 2:
                    {
                        HeaL obj2 = new HeaL();
                        spells.Add(obj2);
                        spell.Replace("2-«Вылечить»"," ");
                        break;
                    }
                case 3:
                    {
                        Protivo9die obj3 = new Protivo9die();
                        spells.Add(obj3);
                        spell.Replace("3-«Противоядие»"," ");
                        break;
                    }
                case 4:
                    {
                        Revive obj4 = new Revive();
                        spells.Add(obj4);
                        spell.Replace("4-«Оживить»"," ");
                        break;
                    }
                case 5:
                    {
                        Armor obj5 = new Armor();
                        spells.Add(obj5);
                        spell.Replace("5-«Броня»"," ");
                        break;
                    }
                case 6:
                    {
                        Otomri obj6 = new Otomri();
                        spells.Add(obj6);
                        spell.Replace("6-«Отомри!»"," ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Добавленны все заклинания");
                        break;
                    }

            }
        }
        public void DelSpell()
        {
            Console.WriteLine("Введите номер заклинания для забытия:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveAt(a);
        }
        public void UseSpell()
        {
            Console.WriteLine("Введите номер заклинания для использования:");
            int a = Convert.ToInt32(Console.ReadLine());
            spells[a].Use(this);
        }
        public void PrintListOfSpells()
        {
            Console.WriteLine($"List currently has {spells.Count} elements.");
            Console.Write("List contents:\n");
            for (int i = 0; i < spells.Count; i++)
            {
                Console.Write($"Номер {i}: {spells[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public override string ToString()
        {
            return "Макс хп"+Maxhp;
        }
    }
}
