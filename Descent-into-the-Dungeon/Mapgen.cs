using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    public class Mapgen
    {
        public static void generator()
        {
          
            int level = 1;
            int MAXPLACE = level + level * 2;

            int[][] ModList = new int[3][];        //модификаторы  
            ModList[0] = new int[1] { 1 };
            ModList[1] = new int[2] { 2, 3 };
            ModList[2] = new int[3] { 1, 3, 5 };

            Mobs mob1 = new Mobs(1, 2, 3, ModList[0]);   //все известные мобы
            Mobs mob2 = new Mobs(2, 3, 4, ModList[1]);
            Mobs mob3 = new Mobs(3, 4, 5, ModList[2]);


            Mobs[] Moblist = new Mobs[3];  /// Массив всех известных мобов, cюда заносить по критериям:
            Moblist[0] = mob1;             /// lvlstart - указатель уровня, с которого появляется в игре
            Moblist[1] = mob2;             /// modnumber -  номер используемого модификатора
            Moblist[2] = mob3;                 /// hp - случайный стат, нужно расширить для всех необходимых 
                                               /// Modlist - лист возможных модификаторов                                                                   
            Mobs[] Placelist = new Mobs[MAXPLACE];
            Random rnd = new Random();


            for (int z = 0; z <= MAXPLACE - 1; z++)                                /////подбираем мобов для уровня, опирась на lvlstart
            {
                int i = rnd.Next(1, Moblist.Length);

                if (Moblist[i].lvlstart >= level)
                {
                    Placelist[z] = Moblist[i];
                    Placelist[z].modnumber = Moblist[i].Modlist[rnd.Next(0, Moblist[i].Modlist.Length)];
                }
                else
                {
                    z = z - 1;
                }

            }

            switch (Placelist[1].modnumber)       //////пример работы модификатора в процессе боя. активатором считать тик, т.е условный клик мыши
            {
                case 1:
                    Fuck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + " Puck you case 1");
                    Console.ReadKey();
                    break;
                case 2:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 2");
                    Console.ReadKey();
                    break;
                case 3:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 3");
                    Console.ReadKey();
                    break;
                case 4:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 4");
                    Console.ReadKey();
                    break;
                case 5:
                    Puck(Placelist[1].hp);
                    Console.WriteLine(Placelist[1].hp + "Fuck you case 5");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    Console.ReadKey();
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
        public int hp;
        public int lvlstart;
        public int modnumber;
        public int[] Modlist; //я гений.            
        public Mobs(int lvlstart, int modnumber, int hp, int[] Modlist)
        {
            this.lvlstart = lvlstart;
            this.modnumber = modnumber;
            this.hp = hp;
            this.Modlist = Modlist;
        }
    }
}
