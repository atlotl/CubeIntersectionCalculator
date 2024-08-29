using Domain.Entities;
using Domain.Services;

namespace Tests
{
    [TestClass]
    public class CubeIntersectionTests
    {
        // Test 1: Verifies that if two cubes do not intersect, the intersection volume is 0.
        [TestMethod]
        public void Cubes_DoNotIntersect_ReturnsZeroVolume()
        {
            // Arrange: Create two cubes with centers that are too far apart and side lengths of 2.
            Cube cube1 = new Cube(new Point3D(0, 0, 0), 2);
            Cube cube2 = new Cube(new Point3D(5, 5, 5), 2);

            // Act
            var volume = CubeIntersectionService.CalculateIntersectionVolume(cube1, cube2);

            // Assert: The intersection volume should be 0 since there is no overlap.
            Assert.AreEqual(0, volume);
        }

        // Test 2: Verifies that if two cubes are completely overlapping, the intersection volume is equal to the volume of one cube.
        [TestMethod]
        public void Cubes_IntersectCompletely_ReturnsCubeVolume()
        {
            // Arrange
            Cube cube1 = new Cube(new Point3D(0, 0, 0), 2);
            Cube cube2 = new Cube(new Point3D(0, 0, 0), 2);

            // Act
            var volume = CubeIntersectionService.CalculateIntersectionVolume(cube1, cube2);

            // Assert: The intersection volume should be 8 (2^3) since they overlap completely.
            Assert.AreEqual(8, volume);
        }

        // Test 3: Verifies that if two cubes intersect partially, the intersection volume is calculated correctly.
        [TestMethod]
        public void Cubes_IntersectPartially_ReturnsPartialVolume()
        {
            // Arrange
            Cube cube1 = new Cube(new Point3D(0, 0, 0), 4);
            Cube cube2 = new Cube(new Point3D(2, 0, 0), 4);

            // Act
            var volume = CubeIntersectionService.CalculateIntersectionVolume(cube1, cube2);

            // Assert: The intersection volume should be 32, which is the volume of the overlapping region (2x4x4).
            Assert.AreEqual(32, volume); 
        }

        // Test 4: Verifies that if two cubes touch at the edge but do not intersect, the intersection volume is 0.
        [TestMethod]
        public void Cubes_IntersectAtEdge_ReturnsZeroVolume()
        {
            // Arrange
            Cube cube1 = new Cube(new Point3D(0, 0, 0), 2);
            Cube cube2 = new Cube(new Point3D(2, 0, 0), 2);

            // Act
            var volume = CubeIntersectionService.CalculateIntersectionVolume(cube1, cube2);

            // Assert: The intersection volume should be 0 as they only touch at the edge.
            Assert.AreEqual(0, volume);
        }
    }
}