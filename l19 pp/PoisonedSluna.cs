using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class PoisonedSluna : Artifact
    {
        public PoisonedSluna():base()
        {
            IsReusable = true;
        }
        public override string ToString()
        {
            return "Ядовитая слюна";
        }
        public override void Use(object p)
        {
            Console.WriteLine("Введите можность артифакта");
            strength = Convert.ToInt32(Console.ReadLine());
            Character a = p as Character;
            if (a.State != "мертв")
            {
                a.State = "отравлен";
                a.HP -= strength;
                if(a.hp<=0)
                {
                    a.State = "Мертв";
                }
            }
            else
            {
                Console.WriteLine("Артефакт не может быть использован");
            }
        }
    }
}
