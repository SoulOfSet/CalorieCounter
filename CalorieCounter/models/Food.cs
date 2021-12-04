namespace CalorieCounter
{
    /// <summary>
    /// A single unit of food consumed by the user
    /// </summary>
    public class Food
    {

        private const int ProteinCalorieFactor = 4;
        private const int CarbCalorieFactor = 4;
        private const int FatCalorieFactor = 9;

        //Getters and setters
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
        public double ServingsConsumed { get; set; }
        public double ProteinPerServing { get; set; }
        public double CarbsPerServing { get; set; }
        public double FatPerServing { get; set; }

        //Calorie calculation
        public double Calories => (ProteinPerServing * ProteinCalorieFactor) + 
            (CarbsPerServing * CarbCalorieFactor) + 
            (FatPerServing * FatCalorieFactor) * ServingsConsumed;
    }
}
