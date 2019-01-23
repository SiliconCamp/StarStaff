using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace GeometryArea.Extentions
{
    public static class TriangleExtentions
    {
        public static bool IsRightTriangle(this Triangle triangle)
        {
            Contract.Assert(triangle != null, "triangle != null");
            Contract.Assert(triangle.Lines != null, "triangle.Lines != null");
            // ReSharper disable once ExceptionNotDocumented
            Contract.Assert(triangle.Lines.Length == 3, "triangle.Lines.Length == 3");
            Contract.Assert(triangle.Lines.All(i => i != null), "Cant get property on triangle with empty line");

            var t = triangle.Lines.OrderBy(i => i.Distanse).ToArray();
            //double is not a good type for direct Eqauls comparasing. That's why we using the small part from the smallest side.
            var epsilon = t[0].Distanse * 0.000001;
            return Math.Abs(Math.Pow(t[0].Distanse, 2) + Math.Pow(t[1].Distanse, 2) - Math.Pow(t[2].Distanse, 2)) < epsilon;
        }
    }
}