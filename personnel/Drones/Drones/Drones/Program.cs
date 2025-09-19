using Drones.Helpers;
using Drones.View;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            List<Building> buildings = new List<Building>();

            for (int i = 0; i < 10; i++)
            {
                Building tony = new Building(100, 100, RandomHelper.randomNmb.Next(1, AirSpace.WIDTH), RandomHelper.randomNmb.Next(1, AirSpace.HEIGHT));
                buildings.Add(tony);
            }
            
               

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}