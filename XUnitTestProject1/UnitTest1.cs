using System;
using UnitTestDemo;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
            Calculator calculator = new Calculator();
           var result= calculator.Addition(1, 3);
            Assert.Equal(4, result);
        }
    }
}
