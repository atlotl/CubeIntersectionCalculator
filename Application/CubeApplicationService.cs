using Domain.Entities;
using Domain.Services;

namespace Application
{
    /// <summary>
    /// Application service responsible for handling operations related to Cube intersection checks and volume calculations.
    /// This class serves as the main entry point for the application layer, coordinating requests from the presentation layer
    /// to the domain services.
    /// </summary>
    public class CubeApplicationService
    {
        /// <summary>
        /// Checks if two cubes intersect in 3D space.
        /// </summary>
        /// <param name="cube1">The first cube to check for intersection.</param>
        /// <param name="cube2">The second cube to check for intersection.</param>
        /// <returns>Returns true if the cubes intersect; otherwise, false.</returns>
        public bool CheckIntersection(Cube cube1, Cube cube2)
        {
            return CubeIntersectionService.AreIntersecting(cube1, cube2);
        }

        /// <summary>
        /// Calculates the volume of intersection between two intersecting cubes.
        /// </summary>
        /// <param name="cube1">The first cube for volume calculation.</param>
        /// <param name="cube2">The second cube for volume calculation.</param>
        /// <returns>Returns the volume of the intersected space. If the cubes do not intersect, returns 0.</returns>
        public double GetIntersectionVolume(Cube cube1, Cube cube2)
        {
            return CubeIntersectionService.CalculateIntersectionVolume(cube1, cube2);
        }
    }
}
