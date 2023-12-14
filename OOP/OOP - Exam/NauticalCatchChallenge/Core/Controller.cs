using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private IRepository<IFish> fishes;
        private IRepository<IDiver> divers;
        public Controller()
        {
            fishes = new FishRepository();
            divers = new DiverRepository();
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            if (divers.GetModel(diverName) == null)
            {
                return string.Format(OutputMessages.DiverNotFound, nameof(DiverRepository), diverName);
            }
            if (fishes.GetModel(fishName) == null)
            {
                return string.Format(OutputMessages.FishNotAllowed, fishName);
            }
            if (divers.GetModel(diverName).HasHealthIssues)
            {
                return string.Format(OutputMessages.DiverHealthCheck, diverName);
            }
            if (divers.GetModel(diverName).OxygenLevel < fishes.GetModel(fishName).TimeToCatch)
            {
                divers.GetModel(diverName).Miss(fishes.GetModel(fishName).TimeToCatch);
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else if (divers.GetModel(diverName).OxygenLevel == fishes.GetModel(fishName).TimeToCatch)
            {
                if (isLucky)
                {
                    divers.GetModel(diverName).Hit(fishes.GetModel(fishName));
                    return string.Format(OutputMessages.DiverHitsFish, diverName, (fishes.GetModel(fishName)).Points, fishName);
                }
                else
                {
                    divers.GetModel(diverName).Miss(fishes.GetModel(fishName).TimeToCatch);
                    return string.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }
            else
            { 
                
                divers.GetModel(diverName).Hit(fishes.GetModel(fishName));
                return string.Format(OutputMessages.DiverHitsFish, diverName, (fishes.GetModel(fishName)).Points, fishName);
            }
        }

        public string CompetitionStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");
            foreach (var diver in divers.Models.OrderByDescending(x => x.CompetitionPoints).ThenByDescending(x => x.Catch.Count).ThenBy(x => x.Name).Where(x => x.HasHealthIssues == false))
            {
                sb.AppendLine(diver.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (diverType != nameof(FreeDiver) && diverType != nameof(ScubaDiver))
            {
                return string.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }
            if (divers.GetModel(diverName) != null)
            {
                return string.Format(OutputMessages.DiverNameDuplication, diverName, nameof(DiverRepository));
            }
            IDiver diver = null;
            if (diverType == nameof(FreeDiver))
            {
                diver = new FreeDiver(diverName);
            }
            else if (diverType == nameof(ScubaDiver))
            {
                diver = new ScubaDiver(diverName);
            }
            divers.AddModel(diver);
            return string.Format(OutputMessages.DiverRegistered, diverName, nameof(DiverRepository));
        }

        public string DiverCatchReport(string diverName)
        {
            StringBuilder sb = new StringBuilder();
            IDiver diver = divers.GetModel(diverName);
            sb.AppendLine(diver.ToString());
            sb.AppendLine("Catch Report:");
            foreach (var fish in diver.Catch)
            {
                sb.AppendLine(fishes.GetModel(fish).ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            int count = 0;
            foreach (var diver in divers.Models.Where(x => x.HasHealthIssues == true))
            {
                diver.RenewOxy();
                diver.UpdateHealthStatus();
                
                count++;
            }
            return string.Format(OutputMessages.DiversRecovered, count);
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fishType != nameof(PredatoryFish) && fishType != nameof(ReefFish) && fishType != nameof(DeepSeaFish))
            {
                return string.Format(OutputMessages.FishTypeNotPresented, fishType);
            }
            if (fishes.GetModel(fishName) != null)
            {
                return string.Format(OutputMessages.FishNameDuplication, fishName, nameof(FishRepository));
            }
            IFish fish = null;
            if (fishType == nameof(PredatoryFish))
            {
                fish = new PredatoryFish(fishName, points);
            }
            else if (fishType == nameof(ReefFish))
            {
                fish = new ReefFish(fishName, points);
            }
            else if (fishType == nameof(DeepSeaFish))
            {
                fish = new DeepSeaFish(fishName, points);
            }
            fishes.AddModel(fish);
            return string.Format(OutputMessages.FishCreated, fishName);
        }
    }
}
