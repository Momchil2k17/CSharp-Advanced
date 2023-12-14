using Raiding.Core;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;
using Vehicles.Core.Interfaces;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IHeroFactory heroFactory = new HeroFactory();

            IEngine engine = new Engine(reader, writer, heroFactory);

            engine.Run();
        }
    }
}