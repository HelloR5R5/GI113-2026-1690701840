using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPosisoned = false;
            if (isPosisoned) { } // ได้เท็จ เพราะ isPosisoned = false
            if (!isPosisoned) { } // ได้จริง เพราะ !isPosisoned = true

            Console.WriteLine("Your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level Input");
            }
            else if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door opens.");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }
        }
    }
}
