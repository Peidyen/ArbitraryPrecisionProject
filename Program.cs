using ExtendedNumerics;
using System;

namespace ArbitraryPrecisionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulation parameters
            BigDecimal.Precision = 4;
            BigDecimal initialPopulation = BigDecimal.Parse("1000"); // Initial population
            BigDecimal growthRate = BigDecimal.Parse("0.03"); // 3% growth rate
            int periods = 100; // Number of periods (e.g., years)

            // Simulate population growth
            Console.WriteLine("Period\tPopulation");

            for (int t = 0; t <= periods; t++)
            {
                BigDecimal population = CalculatePopulation(initialPopulation, growthRate, t);
                Console.WriteLine($"{t}\t{population}");
            }

            Program2.RunSimulation();
            
        }

        static BigDecimal CalculatePopulation(BigDecimal initialPopulation, BigDecimal growthRate, int period)
        {
            // Population at time t = P0 * (1 + r)^t
            BigDecimal onePlusGrowthRate = BigDecimal.Add(BigDecimal.One, growthRate);
            BigDecimal factor = BigDecimal.Pow(onePlusGrowthRate, period);
            BigDecimal population = BigDecimal.Multiply(initialPopulation, factor);

            return population;
        }
    }
}
