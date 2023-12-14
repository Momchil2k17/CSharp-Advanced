using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Repositories
{
    public class FishRepository : IRepository<IFish>
    {
        private List<IFish> fishes;
        public FishRepository() 
        {
            fishes= new List<IFish>();
        }
        public IReadOnlyCollection<IFish> Models => fishes.AsReadOnly();

        public void AddModel(IFish model)
        {
            fishes.Add(model);
        }

        public IFish GetModel(string name)
        {
            return fishes.FirstOrDefault(x => x.Name == name);
        }
    }
}
