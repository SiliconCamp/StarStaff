namespace GeometryArea.Primitives
{
    /// <summary>
    /// You can use System.Drawing.Point struct or this.
    /// </summary>
    public class Point
    {
        #region Public Constructors

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion Public Constructors

        #region Public Properties

        public int X { get; }
        public int Y { get; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            return obj is Point t && X.Equals(t.X) && Y.Equals(t.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        #endregion Public Methods
    }
}