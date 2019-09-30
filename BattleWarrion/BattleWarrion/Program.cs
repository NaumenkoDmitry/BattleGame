using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleWarrion
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior play1 = new Warrior("Player1", 100, 30, 15, 15);//play 1
            Warrior play2 = new Warrior("Player2", 100, 30, 15, 15);//play 2

            Battle battle = new Battle();//  Битва
            battle.addWarrior(play1);//атака первого игрока
            battle.addWarrior(play2);//атака второго игрока

            battle.StartFight();//старт
            Console.ReadLine();

        }
    }
}
