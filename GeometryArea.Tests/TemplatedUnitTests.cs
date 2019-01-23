using System.Diagnostics.Contracts;
using GeometryArea.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryArea.Tests
{
    [TestClass]
    public abstract class TemplatedUnitTests<T> where T : IGeomerty
    {
        protected abstract T BuildInstance();

        public TemplatedUnitTests()
        {
            Contract.ContractFailed += Contract_ContractFailed;
        }

        private void Contract_ContractFailed(object sender, ContractFailedEventArgs e)
        {
            throw new ContractFailedException();
        }

        [TestMethod]
        public void Simple_Get_Perimetr_Test()
        {
            var t = BuildInstance();
            t.GetPerimeter();
        }

        [TestMethod]
        public void Simple_Get_Squard()
        {
            var t = BuildInstance();
            t.GetSquare();
        }
    }
}