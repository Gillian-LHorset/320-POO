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
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();

            for (int i = 0; i < 10; i++)
            {
                //Building building = new Building(100, 100, RandomHelper.randomNmb.Next(1, AirSpace.WIDTH), RandomHelper.randomNmb.Next(1, AirSpace.HEIGHT));
                //buildings.Add(building);

                Factory factory = new Factory(100, 100, RandomHelper.randomNmb.Next(1, AirSpace.WIDTH), RandomHelper.randomNmb.Next(1, AirSpace.HEIGHT));
                factorys.Add(factory);

                Store store = new Store(100, 100, RandomHelper.randomNmb.Next(1, AirSpace.WIDTH), RandomHelper.randomNmb.Next(1, AirSpace.HEIGHT));
                stores.Add(store);
            }

            

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, buildings, factorys, stores));
            } catch (Exception e)
            {
                Console.WriteLine("Problème : " + e.ToString());
            }
        }
    }
}