using GeometryArea.Extentions;
using GeometryArea.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryArea.Tests
{
    [TestClass]
    public class TriangleUnitTests : TemplatedUnitTests<Triangle>
    {
        protected override Triangle BuildInstance()
        {
            return new Triangle(new Point(1, 1), new Point(2, 2), new Point(4, 5));
        }

        [TestMethod]
        public void Check_is_right_triangle_expect_true()
        {
            var t = new Triangle(new Point(0, 0), new Point(0, 3), new Point(4, 0));

            Assert.IsTrue(t.IsRightTriangle());
        }

        [TestMethod]
        public void Check_is_right_triangle_expect_false()
        {
            var t = new Triangle(new Point(1, 1), new Point(0, 3), new Point(4, 0));

            Assert.IsFalse(t.IsRightTriangle());
        }

        [TestMethod]
        [ExpectContractFailure]
        public void Check_is_right_triangle_expect_contracl_fail()
        {
            var t = new Triangle(new Point(1, 1), new Point(0, 3), new Point(4, 0));
            t.Lines[0] = null;
            t.IsRightTriangle();
        }

        [TestMethod]
        [ExpectContractFailure]
        public void Build_with_null_in_ctor_triangle_expect_contracl_fail()
        {
            new Triangle(null, new Point(0, 3), new Point(4, 0));
        }

        [TestMethod]
        [ExpectContractFailure]
        public void Build_with_null_in_ctor_second_triangle_expect_contracl_fail()
        {
            new Triangle(new Point(0, 3), null, new Point(4, 0));
        }

        [TestMethod]
        [ExpectContractFailure]
        public void Build_with_null_in_ctor_third_triangle_expect_contracl_fail()
        {
            new Triangle(new Point(0, 3), new Point(4, 0), null);
        }

        [TestMethod]
        public void triangle_check_square_expect_right_value()
        {
            var t = new Triangle(new Point(0, 3), new Point(4, 0), new Point(0, 0));
            Assert.AreEqual(t.GetSquare(), 3.0 * 4 / 2, 0.0000001);
        }

        [TestMethod]
        public void triangle_check_perimeter_expect_right_value()
        {
            var t = new Triangle(new Point(0, 3), new Point(4, 0), new Point(0, 0));
            Assert.AreEqual(t.GetPerimeter(), 3.0 + 4 + 5, 0.0000001);
        }
    }
}