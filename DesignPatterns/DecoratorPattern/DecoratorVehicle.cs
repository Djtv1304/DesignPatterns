namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorVehicle : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }

        public string GetDescription()
        {
            return $"{Year} {Brand} {Model} {Color}";
        }
    }
}
