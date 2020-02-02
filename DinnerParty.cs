using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty:Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfpeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfpeople;
            FancyDecorations = fancyDecoration;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragePerPerson;
            if (HealthyOption)
                costOfBeveragePerPerson = 5.00M;
            else
                costOfBeveragePerPerson = 20.0M;
            return costOfBeveragePerPerson;
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson()*NumberOfPeople;
                if (HealthyOption)
                    totalCost *= .95M;
                return totalCost;
            }
        }
    }
}
