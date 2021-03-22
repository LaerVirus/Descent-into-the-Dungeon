using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    class Fight
    {
        //Метод для определения победителя
        public static void Win(int hp, int mob_hp)
        {
            if (hp > 0 && mob_hp <= 0) Console.WriteLine("You Win");
            else if (hp <= 0 && mob_hp > 0) Console.WriteLine("You DIED");
        }

        //Метод для нанесения урона
        public static void Damage(ref int hp, ref int power)
        {
            hp -= power;
        }

        //Метод для начала битвы
        public static void Battle(int speed, ref int hp, int power, int mob_hp, int mob_power, int mob_speed)
        {
            if (speed > mob_speed)
            {
                while (hp > 1 && mob_hp > 1)
                {

                    Krit_Damage(ref mob_hp, ref power);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Вы нанесли {1} урона мобу его ставщееся хп {0}", mob_hp, power);
                    Krit_Damage(ref hp, ref mob_power);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Вам нанесли {1} урона ваше оставшееся хп {0}", hp, mob_power);
                    Change(speed, ref hp, power, mob_hp, mob_power, mob_speed);

                }

            }
            else
            {
                while (hp > 1 && mob_hp > 1)
                {

                    Krit_Damage(ref hp, ref mob_power);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Вам нанесли урон {1} ваше оставшееся хп{0}", hp, mob_power);
                    Krit_Damage(ref mob_hp, ref power);
                    Win(hp, mob_hp);
                    if (hp <= 0 || mob_hp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Вы нанесли {1} мобу его ставщееся хп{0}", mob_hp, power);
                    Change(speed, ref hp, power, mob_hp, mob_power, mob_speed);

                }
            }
        }

        //Метод для рандомироавния числа
        private static Random rand = new Random();

        //Метод для выбора действия при битве
        public static void Change(int speed, ref int hp, int power, int mob_hp, int mob_power, int mob_speed)
        {
            Console.WriteLine("Нажмите А для атаки или R для побега");
            string change = Console.ReadLine();
            switch (change)
            {
                case "A": Battle(speed, ref hp, power, mob_hp, mob_power, mob_speed); break;
                case "R": Console.WriteLine("Run"); break;
            }
        }

        /* private static void Dif_Mod(int stata, out int mod)
         { 
             mod = 10 - stata;
         }*/

        //Метод для нанесения крит урона
        private static void Krit_Damage(ref int hp, ref int power)
        {
            int i = rand.Next(1, 10);

            if (i >= 5)
            {
                power = power + 2;
                Damage(ref hp, ref power);
            }
            else
            {
                Damage(ref hp, ref power);
            }

        }
        // private static void Run()




        static void Main(string[] args)
        {
            int hp = 100;
            int mob_hp = 100;
            int power = 50;
            int mob_power = 10;
            int speed = 5;
            int mob_speed = 4;
            Change(speed, ref hp, power, mob_hp, mob_power, mob_speed);
        }
    }
}
