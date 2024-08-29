using Application;
using Domain.Entities;

namespace Presentation
{
    /// <summary>
    /// Entry point for the cube intersection console application. 
    /// This application allows the user to input the dimensions and coordinates of two cubes, 
    /// checks if they intersect, and calculates the volume of intersection.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("Welcome to the Cube Intersection Calculator!");
            Console.WriteLine("This application calculates whether two cubic objects intersect and computes the volume of their intersection.");
            Console.WriteLine("You will be prompted to enter the dimensions and coordinates for two cubes.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine(); // wait for user to press Enter

            do
            {
                CubeApplicationService service = new CubeApplicationService();

                // prompting the user for the first cube's details
                Console.WriteLine("Enter the dimensions and coordinates for the first cube:");
                double sideLength1 = GetDouble("Side length: ");
                double x1 = GetDouble("Cube 1 center X: ");
                double y1 = GetDouble("Cube 1 center Y: ");
                double z1 = GetDouble("Cube 1 center Z: ");

                Cube cube1 = new Cube(new Point3D(x1, y1, z1), sideLength1);

                // prompting the user for the second cube's details
                Console.WriteLine("Enter the dimensions and coordinates for the second cube:");
                double sideLength2 = GetDouble("Side length: ");
                double x2 = GetDouble("Cube 2 center X: ");
                double y2 = GetDouble("Cube 2 center Y: ");
                double z2 = GetDouble("Cube 2 center Z: ");

                Cube cube2 = new Cube(new Point3D(x2, y2, z2), sideLength2);

                // intersection check and volume calculation
                bool intersecting = service.CheckIntersection(cube1, cube2);
                double volume = service.GetIntersectionVolume(cube1, cube2);

                // result display
                Console.WriteLine($"Cubes intersecting: {intersecting}");
                Console.WriteLine($"Intersection volume: {volume}");

                Console.Write("Do you want to calculate another intersection? (y/n): ");

            } while (Console.ReadLine()?.Trim().ToLower() == "y");
        }

        /// <summary>
        /// Prompts the user for a numeric input and ensures that the input is a valid double.
        /// </summary>
        /// <param name="prompt">The message to display when asking for input.</param>
        /// <returns>Returns the valid double value entered by the user.</returns>
        static double GetDouble(string prompt)
        {
            double result;
            Console.Write(prompt);

            // loop until a valid double is entered
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                Console.Write(prompt);
            }
            return result;
        }
    }
}