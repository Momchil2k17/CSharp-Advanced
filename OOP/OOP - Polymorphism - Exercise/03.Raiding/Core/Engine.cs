using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IHeroFactory heroFactory;

        private readonly ICollection<IBaseHero> heroes;

        public Engine(IReader reader, IWriter writer, IHeroFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;
            heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int n = int.Parse(reader.ReadLine());
            while (n > 0)
            {
                try
                {
                    heroes.Add(CreateHero());
                    n--;
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
                foreach (var hero in heroes)
                {
                    writer.WriteLine(hero.CastAbility());
                }
                int bossPower = int.Parse(reader.ReadLine());
                if (bossPower <= heroes.Sum(x => x.Power))
                {
                    writer.WriteLine("Victory!");
                }
                else
                {
                    writer.WriteLine("Defeat...");
                }
            }
        

        private IBaseHero CreateHero()
        {
            string name = reader.ReadLine();
            string type = reader.ReadLine();
            return heroFactory.Create(type, name);
        }
    }
}
