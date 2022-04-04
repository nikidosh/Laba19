using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Character : IComparable
    {
        public List<Artifact> inventory = new List<Artifact>();
        public readonly int ID = 0;
        public readonly string Name;
        private string state;
        public string State
        {
            set
            {
                state = value;
            }
            get { return state; }
        }
        private bool canTalk;
        private bool canValk;
        public bool CanTalk
        {
            set
            {
                canTalk = value;
            }
            get
            {
                return canTalk;
            }
        }
        public bool CanValk
        {
            set
            {
                canValk = value;
            }
            get
            {
                return canValk;
            }
        }
        public readonly string Race;
        public readonly string Gender;
        private int age;
        public int Age
        {
            set
            {
                age = value;
            }
            get { return age; }
        }
        public int hp;
        public int HP
        {
            set
            {
                hp = value;
            }
            get { return hp; }
        }
        public int maxhp;
        public int MaxHP
        {
            set
            {
                maxhp = value;
            }
            get { return maxhp; }
        }
        public int exp;
        public int Exp
        {
            set
            {
                exp = value;
            }
            get { return exp; }
        }

        public int Maxhp { get; internal set; }

        public Character(string newName, string newState, bool CanTalk, bool CanValk, string newRace, string newGender, int nAge, int nHp, int nExp, int nMaxH)
        {
            ID = ID + 1;
            Name = newName;
            State = newState;
            this.CanTalk = CanTalk;
            this.CanValk = CanValk;
            Race = newRace;
            Gender = newGender;
            Age = nAge;
            HP = nHp;
            Exp = nExp;
            MaxHP = nMaxH;
        }
        public int CompareTo(object obj)
        {
            return Exp.CompareTo(obj);
        }
        public void StateChange()
        {
            int persent = MaxHP / 10;
            if (HP < persent)
            {
                State = "Ослаблен";
            }
            else if (HP >= persent)
            {
                State = "Здоров";
            }
            else if (HP == 0)
            {
                State = "Мертв";
            }
        }
        public override string ToString()
        {
            return $"Имя:{Name}\nВозвраст:{Age}\nРаса:{Race}\nID:{ID}\nСостояние:{State}\nПерсонаж может ходить?{CanValk}\nПерсонаж может говорить?{CanTalk}\nОпыт персонажа:{Exp}\nМаксимальное хп:{MaxHP}";
        }
        public void addArtifact()
        {
            string s = @"Введите номер предмета:
            1-Бутылка с живой водой
            2-Бутылка с мертвой водой
            3-Ядовитая слюна
            4-Посох «Молния»
            5-Декокт из лягушачьих лапок
            6-Глаз василиска";
            Console.WriteLine(s);
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Bottle obj1 = new Bottle();
                        inventory.Add(obj1);
                        break;
                    }
                case 2:
                    {
                        DeadWater obj2 = new DeadWater();
                        inventory.Add(obj2);
                        break;
                    }
                case 3:
                    {
                        Flash obj3 = new Flash();
                        inventory.Add(obj3);
                        break;
                    }
                case 4:
                    {
                        Decoct obj4 = new Decoct();
                        inventory.Add(obj4);
                        break;
                    }
                case 5:
                    {
                        PoisonedSluna obj5 = new PoisonedSluna();
                        inventory.Add(obj5);
                        break;
                    }
                case 6:
                    {
                        VasiliskEye obj6 = new VasiliskEye();
                        inventory.Add(obj6);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }

            }
        }
        public void PrintContents()
        {
            Console.WriteLine($"List currently has {inventory.Count} elements.");
            Console.Write("List contents:\n");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"Номер {i}: {inventory[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public void DelArtifact()
        {
            Console.WriteLine("Введите номер артифакта для удаления:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveAt(a);
        }
        public void Use()
        {
            Console.WriteLine("Введите номер артифакта для использования:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory[a].Use(this);
        }

    }
}
