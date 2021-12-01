using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter
{
    /// <summary>
    /// A single unit of food consumed by the user
    /// </summary>
    class Food
    {

        private const int ProteinCalorieFactor = 4;
        private const int CarbCalorieFactor = 4;
        private const int FatCalorieFactor = 9;

        //Getters and setters
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
        public double UnitsConsumed { get; set; }
        public double ProteinPerUnit { get; set; }
        public double CarbsPerUnit { get; set; }
        public double FatPerUnit { get; set; }

        //Calorie calculation
        public double CalculateCalories => (ProteinPerUnit * ProteinCalorieFactor) + (CarbsPerUnit * CarbCalorieFactor) + (FatPerUnit * FatCalorieFactor);
    }
}
