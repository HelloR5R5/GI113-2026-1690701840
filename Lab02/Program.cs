/*
 * Student ID : 1690701840
 * Name       : ชนกานต์ สายควรเจริญ
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            // Character 1 Arthur
            string char1Name = "Arthur";
            char char1rank = 'S';
            int char1Level = 50;
            int char1Hp = 350;
            float char1AttackPower = 75.5f;
            bool char1IsAlive = true;

            Console.WriteLine("===== PARTY STATUS: Arthur =====");
            Console.WriteLine($"Name: {char1Name}");
            Console.WriteLine($"Rank: {char1rank}");
            Console.WriteLine($"Level: {char1Level}");
            Console.WriteLine($"HP: {char1Hp}");
            Console.WriteLine($"Attack Power: {char1AttackPower}");
            Console.WriteLine($"Is Alive: {char1IsAlive}");
            Console.WriteLine();

            // Character 2 Lancelot
            string char2Name = "Lancelot";
            char char2rank = 'A';
            int char2Level = 45;
            int char2Hp = 500;
            double char2AttackPower = 65;
            bool char2IsAlive = true;

            Console.WriteLine("===== PARTY STATUS: Lancelot =====");
            Console.WriteLine($"Name: {char2Name}");
            Console.WriteLine($"Rank: {char2rank}");
            Console.WriteLine($"Level: {char2Level}");
            Console.WriteLine($"HP: {char2Hp}");
            Console.WriteLine($"Attack Power: {char2AttackPower}");
            Console.WriteLine($"Is Alive: {char2IsAlive}");
            Console.WriteLine();

            // Character 3 Guinevere
            string char3Name = "Guinevere";
            char char3rank = 'B';
            int char3Level = 20;
            int char3Hp = 300;
            float char3AttackPower = 40.5f;
            bool char3IsAlive = true;

            Console.WriteLine("===== PARTY STATUS: Guinevere =====");
            Console.WriteLine($"Name: {char3Name}");
            Console.WriteLine($"Rank: {char3rank}");
            Console.WriteLine($"Level: {char3Level}");
            Console.WriteLine($"HP: {char3Hp}");
            Console.WriteLine($"Attack Power: {char3AttackPower}");
            Console.WriteLine($"Is Alive: {char3IsAlive}");
            Console.WriteLine();

            // Character 4 Merlin
            string char4Name = "Merlin";
            char char4rank = 'S';
            int char4Level = 55;
            int char4Hp = 350;
            double char4AttackPower = 120.0;
            bool char4IsAlive = true;

            Console.WriteLine("===== PARTY STATUS: Merlin =====");
            Console.WriteLine($"Name: {char4Name}");
            Console.WriteLine($"Rank: {char4rank}");
            Console.WriteLine($"Level: {char4Level}");
            Console.WriteLine($"HP: {char4Hp}");
            Console.WriteLine($"Attack Power: {char4AttackPower}");
            Console.WriteLine($"Is Alive: {char4IsAlive}");
            Console.WriteLine();
        }
    }
}
