namespace EcerciceParachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Console.CursorVisible = false;

            ConsoleKeyInfo keyPressed;

            Plane plane = new Plane();

            List<Para> paraList = new List<Para>();

            for (int i = 0; i < 8; i++)
            {
                paraList.Add(new Para("bob" + i.ToString()));
            }

            while (true) {

                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey(false);
                    if (keyPressed.Key == ConsoleKey.Spacebar)
                    {

                    }
                }

                plane.PlaneMove();

                Console.Clear();
                plane.Draw();

                Thread.Sleep(500);
            }
        }
    }

    

    
    

}
