using Drones;
using Drones.Interface;
using Drones.View;
using System.Text;
using System.Windows.Forms;
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
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }
    }
}