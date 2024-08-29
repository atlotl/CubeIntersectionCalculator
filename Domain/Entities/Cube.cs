using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Represents a cube in a 3D space. The cube is defined by its center point and side length.
    /// </summary>
    public class Cube
    {
        public Point3D Center { get; set; }
        public double SideLength { get; set; }

        public Cube(Point3D center, double sideLength)
        {
            Center = center;
            SideLength = sideLength;
        }
    }
}
