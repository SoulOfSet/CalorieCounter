using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.models
{
    /// <summary>
    /// Used for reporting
    /// </summary>
    public class ReportData
    {
        public ReportData()
        {

        }

        public DateTime DateTime { get; set; }
        public double TotalCalories { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalProtein { get; set; }
        public double TotalFat { get; set; }
        public double VegetableServings { get; set; }
        public double FruitServings { get; set; }
        public double GrainsServings { get; set; }
        public double NutsServings { get; set; }
        public double MeatServings { get; set; }
        public double FishServings { get; set; }
        public double DairyServings { get; set; }
        public double EggsServings { get; set; }
        public double JunkServings { get; set; }
        public double OtherServings { get; set; }
    }
}
