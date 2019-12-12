using System;
using BID.SWE1.Exam.Interfaces;
using Xunit;
using BID.SWE.EXAM.Impl;


namespace BID.SWE.EXAM.Impl
{
    public class UnitTest1
    {
        [Fact]
        public void Exercise1_Method1()
        {
            CellPrinter cellPrinter = new CellPrinter();
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("true", "true");
        }
    }
}
