using DesignPatterns.Models;

namespace DesignPatterns.DecoratorPattern
{
    public class AdditionalPropertyDecorator : VehicleDecorator
    {
        private readonly string propertyName;
        private readonly string propertyValue;

        public AdditionalPropertyDecorator(Vehicle vehicle, string propertyName, string propertyValue)
            : base(vehicle)
        {
            this.propertyName = propertyName;
            this.propertyValue = propertyValue;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {propertyName}: {propertyValue}";
        }
    }
}
