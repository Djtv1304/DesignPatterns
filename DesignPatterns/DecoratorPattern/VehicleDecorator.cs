using DesignPatterns.Models;

namespace DesignPatterns.DecoratorPattern
{
    public class VehicleDecorator : Vehicle
    {
        protected Vehicle decoratedVehicle;

        public VehicleDecorator(Vehicle vehicle)
        {
            decoratedVehicle = vehicle;
        }

        public virtual string GetDescription()
        {
            return decoratedVehicle.GetDescription();
        }
    }
}
