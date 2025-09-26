using Drones;
using System.Windows.Forms;
using Drones.View;
using System.Text;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Drone_List_plus_que_10()
        {
            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 15; i++)
            {
                Drone drone = new Drone();
                drone.X = 100;
                drone.Y = 100;
                drone.Name = "Joe" + i;
                fleet.Add(drone);
            }

        }
    }
}