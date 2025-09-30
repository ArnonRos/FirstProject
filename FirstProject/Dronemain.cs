using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FirstProject
{
    internal class Dronemain
    {
        static void Main(string[] args) {
            DeliveryDrone[] drones = new DeliveryDrone[3];
            string id;
            int max;
            for (int i = 0; i < drones.Length; i++)
            {
                Console.WriteLine("enter id");
                id = Console.ReadLine();
                Console.WriteLine("enter max weight");
                max = int.Parse(Console.ReadLine());
                try{
                    drones[i] = new DeliveryDrone(id,max);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error in drone number " + i);
                }
                drones[i].TakeOff();
                Console.WriteLine("hhhhhh");
                drones[i].AssignDelivery(2.5, 4);
                try
                {
                    drones[i].land();
                    Console.WriteLine("Landing: Status=" + drones[i].Status + ", Altitude=" + drones[i].CurrentAltitudeMeters);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Landing failed: " + ex.Message);
                }
                Console.WriteLine("battery after: " + drones[i].BatteryPercentage);
            }

        }

    }
}
