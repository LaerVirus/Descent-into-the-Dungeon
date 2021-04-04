using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent_into_the_Dungeon
{
    class Modifiers
    {
        //побочные статы
        static int clear_damage = 8,
                   poison_damage = 15,
                   fire_damage,
                   arrmor_from_stone_skin,
                   hp_regen;
        public static int mob_lvl = 4,
                          modifier_cod = 2;
        //модификаторы
        //вампиризм, 1
        static int Vampirism(int damage)
        {
            return (int)(damage * 0.05);
        }
        //кровотеениe, 2
        static int Bleeding(int clear_damage)
        {
            return clear_damage;
        }
        //яд, 3
        static int Poison(int poison_damage, int hp)
        {
            if (hp <= poison_damage)
                poison_damage = hp - 1;
            return poison_damage;
        }
        //шипы, 4
        static int Thorns(int damage)
        {
            return damage / 10;
        }
        //регенерация, 5
        static int Regeneration(int hp_regen)
        {
            return hp_regen;
        }
        //каменная кожа, 6
        static int Stone_Skin(int arrmor_from_stone_skin)
        {
            return arrmor_from_stone_skin;
        }
        //огненная атака, 7
        static int Fire_Attack(int fire_damage, int arrmor)
        {
            return fire_damage - arrmor / 10;
        }
        //оцепенение, 8
        //метод устнавливающий знаение неточным статам(урон от огня, реген, каменная кожа, яд, кровотечение)
        static void Distribution(int mob_lvl)
        {
            switch (mob_lvl)
            {
                case 1: fire_damage = 1; hp_regen = 1; arrmor_from_stone_skin = 1; poison_damage = 1; clear_damage = 1; break;
                case 2: fire_damage = 2; hp_regen = 2; arrmor_from_stone_skin = 2; poison_damage = 2; clear_damage = 2; break;
                case 3: fire_damage = 3; hp_regen = 3; arrmor_from_stone_skin = 3; poison_damage = 3; clear_damage = 3; break;
                case 4: fire_damage = 4; hp_regen = 4; arrmor_from_stone_skin = 4; poison_damage = 4; clear_damage = 4; break;
                case 5: fire_damage = 5; hp_regen = 5; arrmor_from_stone_skin = 5; poison_damage = 5; clear_damage = 5; break;
                case 6: fire_damage = 6; hp_regen = 6; arrmor_from_stone_skin = 6; poison_damage = 6; clear_damage = 6; break;
                case 7: fire_damage = 7; hp_regen = 7; arrmor_from_stone_skin = 7; poison_damage = 7; clear_damage = 7; break;
                case 8: fire_damage = 8; hp_regen = 8; arrmor_from_stone_skin = 8; poison_damage = 8; clear_damage = 8; break;
            }
        }
        //метод, реализующий работу модификаторов
        public static void Modifier_Selection(ref int hp, int damage, ref int arrmor, int mob_lvl)
        {
            Distribution(mob_lvl);
            switch (modifier_cod)
            {
                case 1: hp += Vampirism(damage); break;
                case 2: hp -= Bleeding(clear_damage); break;
                case 3: hp -= Poison(poison_damage, hp); break;
                case 4: hp -= Thorns(damage); break;
                case 5: hp += Regeneration(hp_regen); break;
                case 6: arrmor += Stone_Skin(arrmor_from_stone_skin); break;
                case 7: hp -= Fire_Attack(fire_damage, arrmor); break;
                case 8: break;
            }
        }
    }
}
