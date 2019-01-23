using System;
using System.Diagnostics.Contracts;
using GeometryArea.Interfaces;

namespace GeometryArea
{
    public class Circle : IGeomerty
    {
        #region Public Constructors

        public Circle(double r)
        {
            Contract.Assert(r >= 0, "Radius mast be bigger then zero.");
            Radius = r;
        }

        #endregion Public Constructors

        #region Public Properties

        public double Radius { get; }

        #endregion Public Properties

        #region Public Methods

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2) / 2;
        }

        #endregion Public Methods
    }
}