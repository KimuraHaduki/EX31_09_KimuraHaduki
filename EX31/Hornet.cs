using System;
using System.Collections.Generic;
using System.Text;

namespace EX31
{
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power) : base(name, hp, power)
        {
        }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に毒針を刺す！");
            if(destination.poisonResistance == false)
            {
                destination.hp = 0;
                Console.WriteLine($"{destination.name}は毒で死んでしまった");
            }
            else
            {
                Console.WriteLine($"しかし{destination.name}には効果がなかった");
            }
        }
    }
}
