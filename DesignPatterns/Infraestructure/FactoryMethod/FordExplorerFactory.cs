using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.FactoryMethod
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Explorer")
                .Build();
        }
    }
}
