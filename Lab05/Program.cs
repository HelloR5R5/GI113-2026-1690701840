using System.Runtime.ConstrainedExecution;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GAME TITLE ===");
            Console.WriteLine("Calculate Damage");

            // Hero Stats
            Console.Write("\nHero Hp: ");
            bool heroHpOk = int .TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int .TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defence: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Mons Stats
            Console.Write("\nMons Hp: ");
            bool monsHpOk = int.TryParse(Console.ReadLine(), out int monsHp);
            Console.Write("Mons Attack: ");
            bool monsAtkOk = int.TryParse(Console.ReadLine(), out int monsAtk);
            Console.Write("Mons Defence: ");
            bool monsDefOk = int.TryParse(Console.ReadLine(), out int monsDef);

            // Check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsInputValid = monsHpOk && monsAtkOk && monsDefOk;
            Console.Write($"\n>> Hero stats valid: {heroInputValid}");
            Console.Write($"\n>> Mons stats valid: {monsInputValid}");
            Console.Write($"\n[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.Write($"\n[Mons] HP: {monsHp}, ATK: {monsAtk}, DEF: {monsDef}");
            Console.WriteLine("");

            // Hero drinks potion before battle
            int potionHeal = 14;
            // heroHp = HeroHp + potionHeal
            // heroHp += potionHeal
            heroHp += potionHeal; //drink potion
            Console.Write($"\nHero drink a potion, healing {potionHeal} Hp, Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monsDef); // Calculate normal damage by minus
            Console.Write($"\nNormal attack deals: {normalDamage} DMG");

            int powerDamage = Math.Max(0, (heroAtk * 2) - monsDef); // Calculate power damage by multiply
            Console.Write($"\nPower attack deals: {powerDamage} DMG");

            int counterDamage = Math.Max(0, monsAtk - heroDef); // Calculate counter damage by minus
            Console.Write($"\nCounter attack deals: {counterDamage} DMG");

            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // Generate a random number between 1 and 100 must + 1
            bool isCrit = roll <= 10; // 10% chance for critical hit
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // use 1 or 0 to determine if crit damage is applied
            Console.Write($"\nCrit Damage roll: {roll} (Crit?: {isCrit})");
            Console.Write($"\nIf Critical, normal attack would deals: {critDamage} DMG");
        }
    }
}
