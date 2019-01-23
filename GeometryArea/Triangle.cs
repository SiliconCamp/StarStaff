using System;
using System.Diagnostics.Contracts;
using System.Linq;
using GeometryArea.Interfaces;
using GeometryArea.Primitives;

namespace GeometryArea
{
    public class Triangle : IGeomerty
    {
        #region Public Constructors

        public Triangle(Point a, Point b, Point c)
        {
            Contract.Assert(a != null, "a != null");
            Contract.Assert(b != null, "b != null");
            Contract.Assert(c != null, "c != null");
            Lines = new ILine[] { new Line(a, b), new Line(a, c), new Line(b, c) };
        }

        public Triangle(ILine a, ILine b, ILine c)
        {
            Contract.Assert(a != null, "a != null");
            Contract.Assert(b != null, "b != null");
            Contract.Assert(c != null, "c != null");
            Lines = new[] { a, b, c };

            var array = Lines.OrderBy(i => i.Distanse).ToArray();
            Contract.Assert(array[0].Distanse + array[1].Distanse <= array[3].Distanse, "Two shortest lines must be bigger than third.");
        }

        #endregion Public Constructors

        #region Public Properties

        public ILine[] Lines { get; }

        #endregion Public Properties

        #region Public Methods

        public double GetPerimeter()
        {
            return Lines[0].Distanse + Lines[1].Distanse + Lines[2].Distanse;
        }

        public double GetSquare()
        {
            var p = (Lines[0].Distanse + Lines[1].Distanse + Lines[2].Distanse) / 2;
            return Math.Sqrt(p * (p - Lines[0].Distanse) * (p - Lines[1].Distanse) * (p - Lines[2].Distanse));
        }

        #endregion Public Methods
    }
}