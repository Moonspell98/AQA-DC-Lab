namespace Homework8.Dictionary
{
    public class City
    {
        public int population;
        public double sqaure;

        public City(int population, double sqare)
        {
            this.population = population;
            this.sqaure = sqare;
        }

        public override string ToString() => $"Population: {population}, square: {sqaure}";
    }
}
