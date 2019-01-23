using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryArea.Tests
{
    public sealed class ExpectContractFailureAttribute : ExpectedExceptionBaseAttribute
    {
        private const string ContractExceptionName = "System.Diagnostics.Contracts.ContractException";

        protected override void Verify(Exception exception)
        {
            if (exception.GetType().FullName != ContractExceptionName)
            {
                base.RethrowIfAssertException(exception);
                throw new Exception("bad exteption. Not expected.");
            }
        }
    }
}