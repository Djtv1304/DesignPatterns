using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Mustang")
                .Build();
        }

    }
}
