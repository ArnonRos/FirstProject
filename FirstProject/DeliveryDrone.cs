using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class DeliveryDrone
    {
        public string Id { get; }
        public double MaxWeightCapacityKg { get; }
        public double BatteryPercentage{ get;private set; }
        public int CurrentAltitudeMeters{  get; private set; }
        public string Status {  get; private set; }

        public DeliveryDrone(string id, double maxWeightCapacity)
        {
            if (id == null || id.Length == 0)
                throw new ArgumentNullException("id does not have a value");
            if (maxWeightCapacity <= 0)
                throw new ArgumentOutOfRangeException("there isnt a max weight capacity");
            Id = id;
            MaxWeightCapacityKg = maxWeightCapacity;
            Status = "grounded";
            CurrentAltitudeMeters = 0;
            BatteryPercentage = 100;
        }

        public DeliveryResult TakeOff()
        {
            if (BatteryPercentage < 30)
                return DeliveryResult.Failure("battery too low");
            if (!Status.Equals("grounded"))
                throw new InvalidOperationException("Drone must be grounded to take off");
            CurrentAltitudeMeters = 50;
            Status = "InFlight";
            return DeliveryResult.Success();
        }
        public DeliveryResult AssignDelivery(double packageWeight, int distanceKm)
        {
            if (packageWeight > MaxWeightCapacityKg)
                return DeliveryResult.Failure();
            if (distanceKm * 5 > BatteryPercentage)
                return DeliveryResult.Failure();
            if (!Status.Equals("InFlight"))
                throw new InvalidOperationException();
            BatteryPercentage -= distanceKm * 5;
            Status = "ReturningHome";
            return DeliveryResult.Success();
        }
        public void land()
        {
            if (!Status.Equals("ReturningHome"))
                throw new InvalidOperationException();
            CurrentAltitudeMeters = 0;
            Status = "grounded";
        }

    }
}
