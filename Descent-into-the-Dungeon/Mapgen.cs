using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    public class Mapgen
    {
        public static void generator(int level)
        {
            int MAXPLACE = level + level * 2;
            int[][] ModList = new int[3][];    
            ModList[0] = new int[1] { 1 };
            ModList[1] = new int[2] { 2, 3 };
            ModList[2] = new int[3] { 1, 3, 5 };
            int[][] Itemlist = new int[3][]; 
            Itemlist[0] = new int[1] { 1 };
            Itemlist[1] = new int[2] { 2, 3 };
            Itemlist[2] = new int[3] { 1, 3, 5 };           
            Mobs[] Moblist = new Mobs[3];  /// известные мобы
            Moblist[0] = new Mobs(1,2,10,1,2,1,1, ModList[0], Itemlist[0], 1);  
            Moblist[1] = new Mobs(2,4,10,10,1,1,1, ModList[1], Itemlist[1], 2);
            Moblist[2] = new Mobs(3,5,3,2,1,2,2, ModList[2], Itemlist[2], 3);                                                      
            Mobs[] Placelist = new Mobs[MAXPLACE]; // месту присваевается моб
            Random rnd = new Random();
            for (int z = 0; z <= MAXPLACE - 1; z++)
            {
                int i = rnd.Next(1, Moblist.Length);
                if (Moblist[i].lvlstart >= level)
                {
                    Placelist[z] = Moblist[i];
                    Placelist[z].modnumber = Moblist[i].Modlist[rnd.Next(0, Moblist[i].Modlist.Length)];
                    Placelist[z].itemnumber = Moblist[i].ItemList[rnd.Next(0, Moblist[i].ItemList.Length)];
                }
                else
                {
                    z = z - 1;
                }
            }
            double maxhp = 0;
            double hp = 0;
            double damage = 0;
            double speed = 0;
            double intelligens=0;
            double armor = 0;
            Items items = new Items(maxhp, hp, damage, speed, intelligens, armor);
            switch (Placelist[1].modnumber)
            {
                case 1:
                    Fuck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + " Puck you case 1");
                    items.itemsmenu(Placelist[1].itemnumber);
                    break;
                case 2:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 2");
                    items.itemsmenu(Placelist[1].itemnumber);
                    break;
                case 3:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 3");
                    items.itemsmenu(Placelist[1].itemnumber);
                    break;
                case 4:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 4");
                    items.itemsmenu(Placelist[1].itemnumber);
                    break;
                case 5:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 5");
                    items.itemsmenu(Placelist[1].itemnumber);
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
            void Fuck(int stat)    //// пример модификатора
            {
                stat = stat + 5;

            }
            void Puck(int stat)    //// пример модификатора
            {
                stat = stat - 5;
            }
        }
    }
    public class Mobs
    {
        public int lvlstart;     
        public int modnumber;
        public int maxhp;
        public int hp;
        public int damage;
        public int speed;
        public int intelligens;
        public int armor;
        public int[] Modlist; //я гений.        
        public int[] ItemList;
        public int itemnumber;
        public Mobs(int lvlstart,int modnumber,int hp,int maxhp,int damage,int speed,int armor,int[] Modlist,int[]ItemList,int itemnumber)
        {
            this.lvlstart = lvlstart; //указатель уровня, с которого появляется в игре
            this.modnumber = modnumber; //номер используемого модификатора
            this.hp = hp;
            this.maxhp = maxhp;
            this.damage = damage;
            this.speed = speed;
            this.armor = armor;
            this.Modlist = Modlist; //известные модификаторы
            this.ItemList = ItemList; //известные предметы
            this.itemnumber = itemnumber;

        }
    }
}
