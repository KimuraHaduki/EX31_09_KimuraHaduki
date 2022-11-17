using System;
using System.Collections.Generic;
using System.Text;

namespace EX31
{
    class Cow : Character
    {
        public Cow(string name, float hp, float power) : base(name, hp, power)
        {
        }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に角で突く！");
            if (this.hp >= 5)
            {
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は体力が足りなくて攻撃できなかった　（残りのHPは{this.hp}、HPが５以上の時に成功します）");
            }
        }
    }
}
