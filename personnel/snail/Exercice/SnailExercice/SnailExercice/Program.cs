namespace SnailExercice
{
    



    internal class Program
    {
        static void Main(string[] args)
        {

            const int SLEEPTIME = 600;

            Snail escargot = new Snail();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 10);
            Console.Write(escargot._body);

            Random rnd = new Random();
            int randomNumberX = rnd.Next(escargot._lifetimeRangeFirst, escargot._lifetimeRangeLast);
            int randomNumberY = rnd.Next(3, 30);

            for (int i = 0; i < randomNumberX; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, randomNumberY);
                Console.Write(escargot._body);
                Thread.Sleep(SLEEPTIME);
            }

            Thread.Sleep(SLEEPTIME);
            Console.Clear();

            Console.SetCursorPosition(randomNumberX, randomNumberY);
            Console.Write("______");
            Console.Read();
            
        }
    }

    class Snail
    {
        public string _body;
        public int _lifetimeRangeFirst;
        public int _lifetimeRangeLast;

        public Snail()
        {
            this._body = "__@__ö";
            this._lifetimeRangeFirst = 5;
            this._lifetimeRangeLast = 40;
        }

        public void start(string body, int lifetime)
        {

        }

    }

}
