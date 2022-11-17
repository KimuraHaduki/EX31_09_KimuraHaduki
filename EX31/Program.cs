using System;

namespace EX31
{
    class Program
    {
        static void Main(string[] args)
        {
            Character human = new Character("人間 ", 50000, 2);
            Cow cow = new Cow("牛 ", 1000, 25);
            Tank tank = new Tank("戦車 ", 500000, 250);
            tank.bullet = 10;
            Cat cat = new Cat("猫 ", 10000, 125);
            Hornet hornet = new Hornet("蜂 ", 300, 20);
            Character[] characters = { human, cow, tank, cat ,hornet};
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(human);
            }
            hornet.Attack(cat);
            hornet.Attack(cow);
            hornet.Attack(tank);
        }
    }
}