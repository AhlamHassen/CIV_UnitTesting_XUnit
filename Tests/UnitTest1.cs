using System;
using Xunit;
using CalcLib;

namespace Tests
{
    //Testing FactorialRec method using Fact
    public class UnitTest1
    {
        [Fact]
        public void FactorialRec_FactTest()
        {
            RecursiveCalc rec = new RecursiveCalc();
            int input = 5;
            int ans = 1;

            Assert.Equal(120, rec.FactorialRec(input, ans));
        }

        //Testing FactorialRec method using Theory
        [Theory]
        [InlineData(5040, 7)]
        [InlineData(24, 4)]
        [InlineData(40320, 8)]

        public void FactorialRec_TheoryTest(int expected, int input)
        {

            RecursiveCalc rec = new RecursiveCalc();
            int ans = 1;
            Assert.Equal(expected, rec.FactorialRec(input, ans));

        }
    }


    //Testing FibCheck method
    public class UnitTest2
    {
        [Fact]
        public void FibCheck_Test()
        {
            RecursiveCalc rec = new RecursiveCalc();
            int num = 21;
            Assert.True(rec.FibCheck(num));
        }
    }

    //Testing PrimeCheckRec method
    public class UnitTest3
    {
        [Fact]
        public void PrimeCheckRec_Test()
        {
            int num = 19;
            int divisor = 2;

            RecursiveCalc rec = new RecursiveCalc();
            Assert.True(rec.PrimeCheckRec(num, divisor));

        }

        //Check for DivideByZeroException
        [Fact]
        public void PrimeCheckRec_TestException()
        {
            RecursiveCalc rec = new RecursiveCalc();
            int num = 19;
            int divisor = 0;
            
            Assert.Throws<DivideByZeroException>(() => rec.PrimeCheckRec(num , divisor));
        }
    }

    //FibonacciRec Test
    public class UnitTest4{
        [Fact]
        public void FibonacciRec_Test()
        {
            RecursiveCalc rec = new RecursiveCalc();
            int num1 = 1;
            int num2 = 7;
            int numFibs = 8;

            Assert.Equal(8288, rec.FibonacciRec(num1, num2, numFibs));
      
        }
    }
}
