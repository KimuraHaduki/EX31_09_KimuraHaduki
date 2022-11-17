using System;
using System.Collections.Generic;
using System.Text;

namespace EX31
{
    class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        public bool poisonResistance;
        public Character(string name, float hp, float power)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.poisonResistance = false;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}