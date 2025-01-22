using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public abstract class CarFactory
    {
        public abstract Vehicle Create();
    }
}
