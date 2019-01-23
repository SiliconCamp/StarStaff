using System;
using System.Diagnostics.Contracts;
using GeometryArea.Interfaces;

namespace GeometryArea.Primitives
{
    public class Line : ILine
    {
        #region Public Constructors

        public Line(Point a, Point b)
        {
            Contract.Assert(a != null, "a != null");
            Contract.Assert(b != null, "b != null");
            A = a;
            B = b;
            Distanse = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        #endregion Public Constructors

        #region Public Properties

        public Point A { get; }
        public Point B { get; }
        public double Distanse { get; }

        #endregion Public Properties
    }
}