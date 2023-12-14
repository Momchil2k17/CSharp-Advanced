using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private double competitionPoints;
        private List<string> cathes;

        protected Diver(string name, int oxygenLevel)
        {
            Name = name;
            OxygenLevel = oxygenLevel;
            cathes = new List<string>();
            CompetitionPoints = 0;
            HasHealthIssues = false;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                }
                name = value;
            }
        }


        public int OxygenLevel
        {
            get { return oxygenLevel; }
            protected set
            {
                if (value <0)
                {
                    oxygenLevel = 0;
                }
                else
                {
                    oxygenLevel = value;
                }
            }
        }

        public IReadOnlyCollection<string> Catch =>cathes.AsReadOnly();

        public double CompetitionPoints 
        {
            get { return Math.Round(competitionPoints,1); }
            private set 
            {
                competitionPoints = value;
            }
        }

        public bool HasHealthIssues { get; private set; }

        public void Hit(IFish fish)
        {
            OxygenLevel -= fish.TimeToCatch;
            cathes.Add(fish.Name);
            CompetitionPoints += fish.Points;
            if (OxygenLevel<=0)
            {
                HasHealthIssues = true;
            }
        }

        public void Miss(int TimeToCatch)
        {
            if (this.GetType().Name==nameof(ScubaDiver))
            {
               OxygenLevel -= (int)Math.Round(0.3 * TimeToCatch, MidpointRounding.AwayFromZero);
            }
            else if (this.GetType().Name == nameof(FreeDiver))
            {
                OxygenLevel -= (int)Math.Round(0.6 * TimeToCatch, MidpointRounding.AwayFromZero);
            }
            if (OxygenLevel <= 0)
            {
                HasHealthIssues = true;
            }

        }

        public void RenewOxy()
        {
            if (this.GetType().Name == nameof(ScubaDiver))
            {
                OxygenLevel = 540;
            }
            else if (this.GetType().Name == nameof(FreeDiver))
            {
                OxygenLevel = 120;
            }
        }

        public void UpdateHealthStatus()
        {
            HasHealthIssues = !HasHealthIssues;
        }
        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {cathes.Count}, Points earned: {CompetitionPoints} ]";
        }
    }
}
