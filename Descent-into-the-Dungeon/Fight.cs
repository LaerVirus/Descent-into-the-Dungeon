using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    class Fight
    {
        //Метод для выбора действия при битве
        public static void Change(int speed, ref int hp, int power, int erudition, int mob_hp, int mob_power, int mob_speed, int mob_erudition)
        {
            Console.WriteLine("Нажмите А для атаки или R для побега");
            string change = Console.ReadLine();
            switch (change)
            {
                case "A": Battle(speed, ref hp, power, erudition, mob_hp, mob_power, mob_speed, mob_erudition); break;
                case "R": Run(ref hp, speed, mob_power); break;
            }
        }

        //Метод для  битвы
        public static void Battle(int speed, ref int hp, int power, int erudition, int mob_hp, int mob_power, int mob_speed, int mob_erudition)
        {
            if (speed > mob_speed)
            {
                while (hp > 1 && mob_hp > 1)
                {
                    Action(ref mob_hp, power, speed, erudition);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Action(ref hp, mob_power, mob_speed, mob_erudition);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Change(speed, ref hp, power, erudition, mob_hp, mob_power, mob_speed, mob_erudition);
                }
            }
            else
            {
                while (hp > 1 && mob_hp > 1)
                {

                    Action(ref hp, mob_power, mob_speed, mob_erudition);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Action(ref mob_hp, power, speed, erudition);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Change(speed, ref hp, power, erudition, mob_hp, mob_power, mob_speed, mob_erudition);
                }
            }
        }

        //Метод для побега от врага
        private static void Run(ref int hp, int speed, int mob_power)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(speed, out mod);
            if (i >= mod)
            {
                Damage(ref hp, ref mob_power);
                Console.WriteLine("Вы  убежали но враг нанёс вам  {0} урона", hp);
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
        public static void Damage(ref int hp, ref int power)
        {
            hp -= power;
        }


        //Метод для рандомироавния числа
        private static Random rand = new Random();

        //Метод для высчитывания влияния модификатора 
        private static void Dif_Mod(int stata, out int mod)
        {
            mod = 100 - stata;
        }

        //Метод для нанесения крит урона
        private static void Krit_Damage(int erudition, int power, ref int hp)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(erudition, out mod);
            //Console.WriteLine("i ==========  {0}",i);
            //Console.WriteLine("mod ==========  {0}", mod);
            if (i >= mod)
            {
                power += 5;
                Damage(ref hp, ref power);
                Console.WriteLine(" нанесён урон {0}", power);
            }
            else
            {
                Damage(ref hp, ref power);
                Console.WriteLine("нанесён урон {0}", power);
            }
        }


        //метод для уклонения
        private static void Evasion(int hp, int speed)
        {
            int i = rand.Next(1, 100);
            int mod;
            Dif_Mod(speed, out mod);
            if (i >= mod)
            {
                Console.WriteLine("уклонение");
            }
        }

        //Метод для возможного исхода
        private static void Action(ref int hp, int power, int speed, int erudition)
        {
            Evasion(hp, speed);
            Krit_Damage(erudition, power, ref hp);
        }

        static void Main(string[] args)
        {
            int hp = 100;
            int erudition = 50;
            int mob_erudition = 25;
            int mob_hp = 100;
            int power = 50;
            int mob_power = 10;
            int speed = 45;
            int mob_speed = 4;
            Change(speed, ref hp, power, erudition, mob_hp, mob_power, mob_speed, mob_erudition);
            Console.ReadKey();
        }
    }
}
