using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public class FordEscapeFactory : CarFactory
    {

        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .Build();
        }

    }
}
