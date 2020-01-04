using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecarations = 0;

        public const int CostOfFoodPerPerson = 25;
        
        public void SetHalthyOption(bool HealthyOption)
        {
            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }

        public void CalculateCostOfDecorations(bool FancyDecoration)
        {
            if (FancyDecoration)
            {
                CostOfDecarations = (NumberOfPeople * 15.00M)  + 50M;
            }
            else
            {
                CostOfDecarations = (NumberOfPeople * 7.50M)  + 30M;
            }
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal totalCost = CostOfDecarations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (HealthyOption)
            {
                return totalCost * 0.95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
