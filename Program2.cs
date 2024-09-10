using System;
using ExtendedNumerics;

namespace ArbitraryPrecisionProject
{
    class Program2
    {
        public static void RunSimulation()
        {
            // Parameters for the simulation
            BigDecimal amplitude = BigDecimal.Parse("1.0");  // Amplitude (meters)
            BigDecimal wavelength = BigDecimal.Parse("0.001"); // Wavelength (meters, very small)
            BigDecimal frequency = BigDecimal.Parse("1000000"); // Frequency (Hz, high frequency)
            BigDecimal time = BigDecimal.Parse("0.0"); // Initial time (seconds)

            // Define wave number k = 2π/λ
            BigDecimal pi = BigDecimal.Pi;
            BigDecimal k = BigDecimal.Divide(BigDecimal.Multiply(pi, 2), wavelength);

            // Define angular frequency ω = 2πf
            BigDecimal omega = BigDecimal.Multiply(BigDecimal.Multiply(BigDecimal.Pi, 2), frequency);

            // Simulation parameters
            int points = 100; // Number of points along the string
            BigDecimal timeStep = BigDecimal.Parse("0.000001"); // Time step for the simulation (seconds)

            Console.WriteLine("String Theory Simulation - Vibration of a String");

            // Loop through each point in time
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Time: {time}");
                
                // Simulate string at different points along the length
                for (int x = 0; x <= points; x++)
                {
                    BigDecimal position = BigDecimal.Divide(BigDecimal.Parse(x.ToString()), BigDecimal.Parse(points.ToString()));
                    BigDecimal displacement = CalculateDisplacement(amplitude, k, omega, position, time);
                    Console.WriteLine($"x: {position}, Displacement: {displacement}");
                }

                // Increment time
                time = BigDecimal.Add(time, timeStep);
            }
        }

        // Method to calculate the displacement of the string at a given position and time
        static BigDecimal CalculateDisplacement(BigDecimal amplitude, BigDecimal k, BigDecimal omega, BigDecimal x, BigDecimal t)
        {
            // y(x, t) = A * sin(kx - ωt)
            BigDecimal phase = BigDecimal.Subtract(BigDecimal.Multiply(k, x), BigDecimal.Multiply(omega, t));
            BigDecimal sineValue = BigDecimal.Sin(phase);
            return BigDecimal.Multiply(amplitude, sineValue);
        }
    }
}
