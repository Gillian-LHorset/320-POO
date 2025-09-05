namespace EcerciceParachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Console.CursorVisible = false;

            Plane plane = new Plane();

            List<Para> paraList = new List<Para>();

            for (int i = 0; i < 8; i++)
            {
                paraList.Add(new Para("bob"));
            }

            while (true) {

                if (Console.KeyAvailable)
                {
                    
                }

                plane.PlaneMove();

                Console.Clear();
                plane.Draw();

                Thread.Sleep(500);
            }
        }
    }

    

    
    

}
