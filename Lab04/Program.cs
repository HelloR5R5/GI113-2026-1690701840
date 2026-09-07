namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---+");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Name your hero: ");
            string playerNmae = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {playerNmae}. Your adventure begins now...");

            Console.WriteLine("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}.}");
        }
    }
}
