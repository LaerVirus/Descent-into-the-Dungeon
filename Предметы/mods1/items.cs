using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mods1
{
    class Items
    {
        public double maxhp;
        public double hp;
        public double damage;
        public double speed;
        public double intelligens;
        public double armor;

        public Items(double maxhp, double hp, double damage, double speed, double intelligens, double armor)
        {
            this.maxhp = maxhp;
            this.hp = hp;
            this.damage = damage;
            this.speed = speed;
            this.intelligens = intelligens;
            this.armor = armor;
        }

       public  void itemsmenu ()
        {
           /////////////////////////////////////////////////////////                            
            Random x = new Random();
            int n = x.Next(0, 28);
            double hp = maxhp;
            if (hp > maxhp)
            {
                hp = maxhp;
            }
            switch (n)
            {
                case 0:
                    item0(ref maxhp);
                    Console.WriteLine($"вы получили фрукт жизни , тем самым увеличили свой запас здоровья ставшее : { maxhp}  ");
                    break;
                case 1:
                    item1(ref maxhp);
                    Console.WriteLine($"вы получили Плоть Исаака , тем самым увеличили свой запас здоровья ставшее :  { maxhp}  ");
                    break;
                case 2:
                    item2(ref maxhp);
                    Console.WriteLine($"вы получили Обэмэ , тем самым увеличили свой запас здоровья ставшее :   {maxhp}");
                    break;
                case 3:
                    item3(ref maxhp);
                    Console.WriteLine($"вы получили Кристальное сердце ,, тем самым увеличили свой запас здоровья ставшее :  {maxhp} ");
                    break;
                case 4:
                    item4(ref damage);
                    Console.WriteLine($"вы получили Обычный Меч , тем самым увеличили свою силу {damage} ");
                    break;
                case 5:
                    item5(ref damage);
                    Console.WriteLine($"вы получили Стальной боевой топор  , тем самым увеличили свою силу {damage}  ");
                    break;
                case 6:
                    item6(ref damage);
                    Console.WriteLine($"вы получили Эльфийский двуручный меч , тем самым увеличили свою силу {damage} ");
                    break;
                case 7:
                    item7(ref damage);
                    Console.WriteLine($"вы получили Секирy орка , тем самым увеличили свою силу {damage}  ");
                    break;
                case 8:
                    itemt8(ref damage);
                    Console.WriteLine($"вы получили Эбонитовый меч , тем самым увеличили свою силу {damage}  ");
                    break;
                case 9:
                    item9(ref armor);
                    Console.WriteLine($"вы получили Кожаные шлем  , тем самым увеличили свою мощь {armor} ");
                    break;
                case 10:
                    item0(ref armor);
                    break;
                case 11:
                    item1(ref armor);
                    Console.WriteLine($"вы получили Стальнyю кольчугу , тем самым увеличили свой запас прочности { armor}  ");
                    break;
                case 12:
                    item2(ref armor);
                    Console.WriteLine($"вы получили Эльфийские доспехи , тем самым увеличили свой запас прочности {armor}");
                    break;
                case 13:
                    item3(ref armor);
                    Console.WriteLine($"вы получили Орочий нагрудник , тем самым увеличили свой запас прочности {armor} ");
                    break;
                case 14:
                    item4(ref intelligens);
                    Console.WriteLine($"вы получили очки, тем самым увеличили свой интеллект{intelligens} ");
                    break;
                case 15:
                    item5(ref hp);
                    Console.WriteLine($"вы получили Маленькое зелье здоровья , тем самым увеличили свой запас здоровья ставшее :  {hp}  ");
                    break;
                case 16:
                    item6(ref hp);
                    Console.WriteLine($"вы получили Среднее зелье здоровья, тем самым увеличили свой запас здоровья ставшее :  {hp} ");
                    break;
                case 17:
                    item7(ref hp);
                    Console.WriteLine($"вы получили Большое зелье здоровья  , тем самым увеличили свой запас здоровья ставшее : {hp}  ");
                    break;
                case 18:
                    itemt8(ref speed);
                    Console.WriteLine($"вы получили Сандали с крыльями , тем самым увеличили щанс уйти от удара {speed}  ");
                    break;
                case 19:
                    item9(ref speed);
                    Console.WriteLine($"вы получили Тканевые ботинки   , тем самым увеличили щанс уйти от удара {speed}");
                    break;
                case 20:
                    item0(ref speed);
                    Console.WriteLine($"вы получили Обычные кроссовки , тем самым увеличили щанс уйти от удара {speed} ");
                    break;
                case 21:
                    item1(ref speed);
                    Console.WriteLine($"вы получили Спортивная обувь  , тем самым увеличили щанс уйти от удара  { speed}  ");
                    break;
                case 22:
                    item2(ref armor);
                    Console.WriteLine($"вы получили шлем и броню ,тем самым увеличили свой запас прочности {armor}");
                    break;
                case 23:
                    item3(ref armor);
                    Console.WriteLine($"вы получили Плащ Цукасы ,тем самым увеличили свой запас прочности {armor} ");
                    break;
                case 24:
                    item4(ref hp);
                    Console.WriteLine($"вы получили Клетки Титана , тем самым увеличили свой запас здоровья ставшее : {hp} ");
                    break;
                case 25:
                    item5(ref damage);
                    Console.WriteLine($"вы получили Клинок, рассекающий демонов  {damage}  ");
                    break;
                case 26:
                    item6(ref damage);
                    Console.WriteLine($"вы получили Меч Гермеса , тем самым увеличили свою силу  {damage} ");
                    break;
                case 27:
                    item7(ref maxhp);
                    Console.WriteLine($"вы получили Heart of Tarrasque , тем самым увеличили свой запас здоровья ставшее : {maxhp}  ");
                    break;
            }
            Console.ReadKey();
        }
        static double item0(ref double maxhp)
        {
            //фрукт жизни
            maxhp += 5;
            return maxhp;
        }
        static double item1(ref double maxhp)
        {
            //Плоть Исаака
            maxhp += 10;/////////////////////////////////////////////////////имба
            return maxhp;
        }
        static double item2(ref double maxhp)
        {
            //Обэмэ
            maxhp += 15;/////////////////////////////////////////////////////имба
            return maxhp;
        }
        static double item3(ref double maxhp)
        {
            //Кристальное сердце   /////////////////////////////////////////////////////имба
            maxhp += 20;
            return maxhp;
        }
        static double item4(ref double damage)
        {
            //Обычный Меч
            damage += 1;
            return damage;
        }
        static double item5(ref double damage)
        {
            //Стальной боевой топор 
            damage += 2;
            return damage;
        }
        static double item6(ref double damage)
        {
            //Эльфийский двуручный меч
            damage += 3;
            return damage;
        }
        static double item7(ref double damage)
        {
            //Секира орка
            damage += 3;
            return damage;
        }
        static double itemt8(ref double damage)
        {
            //Эбонитовый меч 
            damage += 5;
            return damage;
        }
        static double item9(ref double armor)
        {
            //Кожаные шлем
            armor += 1;
            return armor;
        }
        static double item10(ref double armor)
        {
            //Стальная кольчуга
            armor += 2;
            return armor;
        }
        static double item11(ref double armor)
        {
            //Эльфийские доспехи
            armor += 3;
            return armor;
        }
        static double item12(ref double armor)
        {
            //Орочий нагрудник
            armor += 4;
            return armor;
        }
        static double item13(ref double armor)
        {
            //Эбонитовые доспехи 
            armor += 5;
            return armor;
        }
        static double item14(ref double intelligens)
        {
            //очки
            intelligens += 1;
            return intelligens;
        }
        static double item15(ref double hp)
        {
            //Маленькое зелье здоровья ////////////////////////////////////////////////////имба
            hp += 10;
            return hp;
        }
        static double item16(ref double hp)
        {
            //Среднее зелье здоровья ////////////////////////////////////////////////////имба
            hp += 20;
            return hp;
        }
        static double item17(ref double hp)
        {
            //Большое зелье здоровья////////////////////////////////////////////////////имба
            hp += 20;
            return hp;
        }
        static double itemt18(ref double speed)
        {
            //Сандали с крыльями
            speed += 1;
            return speed;
        }
        static double item19(ref double speed)
        {
            //Тканевые ботинки
            speed += 1;
            return speed;
        }
        static double item20(ref double speed)
        {
            //Oбычные кроссовки
            speed += 2;
            return speed;
        }
        static double item21(ref double speed)
        {
            //Спортивная обувь
            speed += 3;
            return speed;
        }
        static double item22(ref double armor)
        {
            //Armor + helm ////////////////////////////////////////////////////имба
            armor += 12;
            return armor;
        }
        static double item23(ref double armor)
        {
            //Плащ Цукасы/////////////////////////////////////////////////////имба
            armor += 12;
            return armor;
        }
        static double item24(ref double hp)
        {
            //Клетки Титана
            hp += 4;
            return hp;
        }
        static double item25(ref double damage)
        {
            //Клинок, рассекающий демонов
            damage += 12;/////////////////////////////////////////////////////имба
            return damage;
        }
        static double item26(ref double damage)
        {
            //Меч Гермеса
            damage += 12;/////////////////////////////////////////////////////имба
            return damage;
        }
        static double item27(ref double maxhp)
        {
            //Heart of Tarrasque/////////////////////////////////////////////////////имба
            maxhp += 40;
            return maxhp;
        }
        public void Print()
        {
            Console.WriteLine($"значение хп:{ hp} ");
            Console.WriteLine($"значение брони :{armor} " );
            Console.WriteLine($" значение скорости :{speed} " );
            Console.WriteLine($" значение интеллекта :{intelligens} " );
            Console.WriteLine($" значение урона : {damage}" );
        }
    }
}