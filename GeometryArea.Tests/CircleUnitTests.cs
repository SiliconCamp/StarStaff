using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable ObjectCreationAsStatement

namespace GeometryArea.Tests
{
    [TestClass]
    public class CircleUnitTests : TemplatedUnitTests<Circle>
    {
        protected override Circle BuildInstance()
        {
            return new Circle(5);
        }

        [TestMethod]
        public void Simple_Init_Test()
        {
            new Circle(0.5);
        }

        [TestMethod, ExpectContractFailure]
        public void Init_Test_with_negative_radius_expect_contract_fail()
        {
            new Circle(-0.5);
        }

        [TestMethod]
        public void Circle_check_square_expect_right_value()
        {
            var t = new Circle(1);
            Assert.AreEqual(t.GetSquare(), Math.PI / 2);
        }

        [TestMethod]
        public void Circle_check_perimeter_expect_right_value()
        {
            var t = new Circle(1);
            Assert.AreEqual(t.GetPerimeter(), Math.PI * 2);
        }
    }
}