using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    /// <summary>
    /// Provides static methods to check if two cubes intersect in 3D space and to calculate the volume of their intersection.
    /// This service is a part of the Domain layer and contains core business logic for cube intersection calculations.
    /// </summary>
    public static class CubeIntersectionService
    {
        /// <summary>
        /// Determines if two cubes intersect in 3D space.
        /// </summary>
        /// <param name="cube1">The first cube to check for intersection.</param>
        /// <param name="cube2">The second cube to check for intersection.</param>
        /// <returns>Returns true if the cubes intersect; otherwise, false.</returns>
        public static bool AreIntersecting(Cube cube1, Cube cube2)
        {
            // check if there is no overlap in the X, Y, or Z dimensions.
            return !(cube1.Center.X + cube1.SideLength / 2 < cube2.Center.X - cube2.SideLength / 2 ||
                     cube1.Center.X - cube1.SideLength / 2 > cube2.Center.X + cube2.SideLength / 2 ||
                     cube1.Center.Y + cube1.SideLength / 2 < cube2.Center.Y - cube2.SideLength / 2 ||
                     cube1.Center.Y - cube1.SideLength / 2 > cube2.Center.Y + cube2.SideLength / 2 ||
                     cube1.Center.Z + cube1.SideLength / 2 < cube2.Center.Z - cube2.SideLength / 2 ||
                     cube1.Center.Z - cube1.SideLength / 2 > cube2.Center.Z + cube2.SideLength / 2);
        }

        /// <summary>
        /// Calculates the volume of the intersection between two intersecting cubes in 3D space.
        /// If the cubes do not intersect, returns 0.
        /// </summary>
        /// <param name="cube1">The first cube for volume calculation.</param>
        /// <param name="cube2">The second cube for volume calculation.</param>
        /// <returns>Returns the volume of the intersected space. If the cubes do not intersect, returns 0.</returns>
        public static double CalculateIntersectionVolume(Cube cube1, Cube cube2)
        {
            // if the cubes do not intersect, return 0.
            if (!AreIntersecting(cube1, cube2))
                return 0;

            // calculate the overlap in the X, Y, and Z dimensions.
            double xOverlap = Math.Max(0, Math.Min(cube1.Center.X + cube1.SideLength / 2, cube2.Center.X + cube2.SideLength / 2) - Math.Max(cube1.Center.X - cube1.SideLength / 2, cube2.Center.X - cube2.SideLength / 2));
            double yOverlap = Math.Max(0, Math.Min(cube1.Center.Y + cube1.SideLength / 2, cube2.Center.Y + cube2.SideLength / 2) - Math.Max(cube1.Center.Y - cube1.SideLength / 2, cube2.Center.Y - cube2.SideLength / 2));
            double zOverlap = Math.Max(0, Math.Min(cube1.Center.Z + cube1.SideLength / 2, cube2.Center.Z + cube2.SideLength / 2) - Math.Max(cube1.Center.Z - cube1.SideLength / 2, cube2.Center.Z - cube2.SideLength / 2));

            return xOverlap * yOverlap * zOverlap;
        }
    }
}
