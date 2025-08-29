namespace SnailExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 10);
            Console.Write("__@__ö");

            Random rnd = new Random();
            int randomNumberX = rnd.Next(10, 40);
            int randomNumberY = rnd.Next(3, 30);

            for (int i = 0; i < randomNumberX; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, randomNumberY);
                Console.Write("__@__ö");
                Thread.Sleep(750);
            }

            Thread.Sleep(750);
            Console.Clear();

            Console.SetCursorPosition(randomNumberX, randomNumberY);
            Console.Write("______");
            Console.Read();
        }
    }
}
