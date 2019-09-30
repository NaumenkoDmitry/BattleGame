using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleWarrion
{
    class Warrior
    {
        public string name { get; set; } = "Warrior";//Имя
        public int health { get; set; } = 0;//Здоровье
        public int hardAttackMax { get; set; } = 0;//Максимум атаки
        public int lightAttackMax { get; set; } = 0;//Минимум атаки
        public int treatmentMax { get; set; } = 0;// Восстановление здоровья
        Random rnd = new Random();// Рандом

        public Warrior(string name = "Warrior",//Имя
            int health = 0, //Здоровье
            int hardAttackMax = 0,//Макс атаки
            int lightAttackMax = 0,//Мин Атаки
            int treatmentMax = 0)// лечение

        {
            this.name = name;//имя 
            this.health = health;//здоровье
            this.hardAttackMax = hardAttackMax;//Макс атаки
            this.lightAttackMax = lightAttackMax;//Мин Атаки

        }

        public int reduceHealth(int value)// уменьшить здоровье
        {
            this.health -= value;
            if (this.health < 0)
            {
                this.health = 0;

            }
            return this.health;
        }
        public int increaseHealth()// увеличить здоровье
        {
            this.health += rnd.Next(0, this.treatmentMax);
            if (this.health > 100)
            {
                this.health = 100;

            }
            return this.health;
        }
        public int Attack()//атака
        {
            int action = rnd.Next(1, 3);
            int val = 0;
            switch (action)
            {
                case 1:
                    val = rnd.Next(0, this.lightAttackMax);
                    Console.WriteLine("Light kick {0}", val);//Легкий удар
                    return val;
                case 2:
                    val = rnd.Next(0, this.hardAttackMax);
                    Console.WriteLine("Hard kick {0}",val);//Сильный удар
                    return val;

                case 3:
                    val = this.increaseHealth();
                    Console.WriteLine("Heals [0]",val);//лечение             
                    break;
            }
            return 0;


        }



    }
}
