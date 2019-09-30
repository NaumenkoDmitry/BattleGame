using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleWarrion
{
    class Battle
    {
        protected Warrior[] warriors = new Warrior[2];
        protected int warriorsCount = 0;
        public void printState()
        {//статистика
            Console.WriteLine("{0} it has {1} health\n",
                this.warriors[0].name,
                 this.warriors[0].health);
            Console.WriteLine("{0} it has {1} health\n",
                this.warriors[1].name,
                 this.warriors[1].health);
        }
        public bool isGameOver()//конец игры
        {
            if (this.warriors[0].health == 0 || this.warriors[1].health == 0)
            {
                return true;

            }
            return false;
        }
        public void addWarrior(Warrior warrior)// добавление
        {
            this.warriors[this.warriorsCount] = warrior;
            this.warriorsCount++;
        }
        public void StartFight()
        {
            Random rand = new Random();
            while (true)
            {
                int first = rand.Next(2);
                int second = first == 0 ? 1 : 0;
                Console.WriteLine("Attack of {0}", this.warriors[second].name);// сообщение об атаке

                this.warriors[first].reduceHealth(this.warriors[second].Attack());
                this.printState();

                if (this.isGameOver())
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
    }
}
