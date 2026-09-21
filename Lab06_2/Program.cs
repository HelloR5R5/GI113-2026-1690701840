using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isPosisoned = false;
            //if (isPosisoned) { } // ได้เท็จ เพราะ isPosisoned = false
            //if (!isPosisoned) { } // ได้จริง เพราะ !isPosisoned = true

            //bool hasKey = true; //มีคีย true/false

            //Console.WriteLine("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level Input");
            //}
            //else if (level >= 10 && hasKey) // && = and, || = or
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //    if (hasKey)
            //    {
            //        Console.WriteLine("The door opens.");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked. Find a key.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");

            int heroHp = 80;
            int potionHeal = 20;

            Console.WriteLine("Game Title: Hero's Run");
            Console.WriteLine("Hero encounters a hole in the ground, while running from monsters.");
            Console.WriteLine("ACTION 1: Jump over the hole");
            Console.WriteLine("ACTION 2: Jump into the hole");
            Console.WriteLine("ACTION 3: Heal yourself");

            Console.WriteLine("Choose an action (1-3): ");
            bool isInputOk = int.TryParse(Console.ReadLine(), out int action);

            if (isInputOk == false || action < 1 || action > 3)
            {
                Console.WriteLine("Invalid action input, Please choose action 1 to 3.");
            }
            else if (action == 1)
            {
                Console.WriteLine("Hero jumps over the hole and continues running.");
            }
            else if (action == 2)
            {
                Console.WriteLine("Hero jumps into the hole and loses 25 HP.");
            }
            else if (action == 3)
            {
                heroHp += potionHeal;
                if (heroHp >= 100)
                {
                    heroHp = 100;
                    Console.WriteLine($"Hero heals himself and gains {potionHeal} HP. Hero is at full health!!");
                }
                else
                {
                    Console.WriteLine($"Hero heals himself and gains {potionHeal} HP.");
                }
                Console.WriteLine($"Hero's current HP: {heroHp}");
            }
        }
    }
}
