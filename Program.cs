using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hobo[] hobos = new Hobo[3];

            Normal normal = new Normal();
            normal.Name = "Олег";

            Uzbek uzbek = new Uzbek();
            uzbek.Name = "Рафаэл";

            Grandma grandma = new Grandma();
            grandma.Name = "Галина";

            hobos[0] = normal;
            hobos[1] = uzbek;
            hobos[2] = grandma;

            for (int i = 0; i < hobos.Length; i++)
            {   
                Console.WriteLine($"Бездомный {hobos[i].Name} говорит:");
                hobos[i].BattleCry();
            }

            Console.ReadKey();
        }
    }

    class Hobo
    {
        public string Name { get; set; }

        public virtual void BattleCry()
        {
            Console.WriteLine("ЭЭЭ, мелочи не будет?");
        }

    }

    class Normal : Hobo
    {
        public override void BattleCry()
        {
            Console.WriteLine("Сигератки не найдется?");
        }
    }
    class Uzbek : Hobo
    {
        public override void BattleCry()
        {
            Console.WriteLine("Арзимас нарсалар топилмадими?");
        }
    }
    class Grandma : Hobo
    {
        public override void BattleCry()
        {
            Console.WriteLine("Вокруг одни шлюхи и наркоманы.");
        }
    }

}

