using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    class Fight
    {
        public static string change;
        //Метод для выбора действия при битве
        public static void Change(int speed, ref int hp, int power, int erudition, int arrmor, ref int mob_hp, int mob_power, int mob_speed, int mob_erudition, int mob_arrmor)
        {
            Console.WriteLine("Нажмите А для атаки или R для побега");
            change = Console.ReadLine();
            change = change.ToUpper();
            switch (change)
            {
                case "A": Battle(speed, ref hp, power, erudition, arrmor, ref mob_hp, mob_power, mob_speed, mob_erudition, mob_arrmor); break;
                case "R": Run(ref hp, speed, mob_power, arrmor); break;
            }
        }

        //Метод для  битвы
        public static void Battle(int speed, ref int hp, int power, int erudition, int arrmor, ref int mob_hp, int mob_power, int mob_speed, int mob_erudition, int mob_arrmor)
        {
            while (true)
            {
                if (speed > mob_speed)
                {
                    Action(ref mob_hp, power, speed, erudition, mob_arrmor);
                    if (mob_hp <= 0)
                    {
                        Win(hp, mob_hp);
                        break;
                    }
                    Action(ref hp, mob_power, mob_speed, mob_erudition, arrmor);
                    if (hp <= 0)
                    {
                        Win(hp, mob_hp);
                        break;
                    }
                }
                else
                {
                    Action(ref hp, mob_power, mob_speed, mob_erudition, arrmor);
                    if (hp <= 0)
                    {
                        Win(hp, mob_hp);
                        break;
                    }
                    Action(ref mob_hp, power, speed, erudition, mob_arrmor);
                    if (mob_hp <= 0)
                    {
                        Win(hp, mob_hp);
                        break;
                    }
                }
                Change(speed, ref hp, power, erudition, arrmor, ref mob_hp, mob_power, mob_speed, mob_erudition, mob_arrmor);
                if (change == "R")
                    break;
            }
        }

        //Метод для побега от врага
        private static void Run(ref int hp, int speed, int mob_power, int arrmor)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(speed, out mod);
            if (i >= mod)
            {
                Damage(ref hp, mob_power, arrmor);
                Console.WriteLine("Вы убежали, но враг оставил вам {0} хп", hp);
            }
            else
            {
                Console.WriteLine("Вы успешно убежали");
            }

        }

        //Метод для определения победителя
        public static void Win(int hp, int mob_hp)
        {
            if (hp > 0 && mob_hp <= 0) Console.WriteLine("Вы нанесли последний удар You Win");
            else if (hp <= 0 && mob_hp > 0) Console.WriteLine("Вам нанесли последний удар You DIED");
        }

        //Метод для нанесения урона
        public static void Damage(ref int hp, int power, int arrmor)
        {
            if (power <= arrmor)
                power = 1;
            else
                power -= arrmor;
            hp -= power;
        }


        //Метод для рандомироавния числа
        private static Random rand = new Random();

        //Метод для высчитывания влияния модификатора 
        private static void Dif_Mod(int stata, out int mod)
        {
            mod = 100 - stata;
        }

        //Метод для нанесения урона
        private static void Krit_Damage(int erudition, int power, ref int hp, int arrmor)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(erudition, out mod);
            //Console.WriteLine("i ==========  {0}",i);
            //Console.WriteLine("mod ==========  {0}", mod);
            if (i >= mod)
            {
                power = (int)(power * 1.5);
                Console.WriteLine("Критический урон!!!");
            }
            //Modifiers.Modifier_Selection(ref hp, power, ref arrmor, Modifiers.mob_lvl);
            Damage(ref hp, power, arrmor);
            Console.WriteLine("Нанесён урон - {0}", power);
            Console.WriteLine("Оставшееся хп - {0}", hp);
        }
        //метод для уклонения
        private static void Evasion(ref int hp, int power, int speed, int erudition, int arrmor)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(speed, out mod);
            if (i >= mod)
            {
                Console.WriteLine("Уклонение");
                Console.WriteLine("Оставшееся хп - {0}", hp);
            }
            else
                Krit_Damage(erudition, power, ref hp, arrmor);
        }
        //Метод для возможного исхода
        private static void Action(ref int hp, int power, int speed, int erudition, int arrmor)
        {
            Evasion(ref hp, power, speed, erudition, arrmor);
        }

        static void Main(string[] args)
        {
            int hp = 100;
            int erudition = 50;
            int mob_erudition = 25;
            int mob_hp = 100;
            int power = 20;
            int mob_power = 10;
            int speed = 45;
            int mob_speed = 4;
            int arrmor = 5;
            int mob_arrmor = 5;
            Change(speed, ref hp, power, erudition, arrmor, ref mob_hp, mob_power, mob_speed, mob_erudition, mob_arrmor);
            Console.ReadKey();
        }
    }
}
