namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0; //ตัวแปรหลักเพื่อเช็ก

            //if (lives >= 0) //ในวงเล็บคือเงื่อนไขที่จะต้องเป็นจริง
            //{
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play");
            //}

            //Console.WriteLine("continue to run");

            int level = 7;

            if (level >= 10)
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
