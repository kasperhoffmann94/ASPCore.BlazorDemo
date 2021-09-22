using System;
using Xunit;
using Bunit;
using BlazorDemo.Pages;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private IsPrime isPrime = new IsPrime();
        private IsSqrt isSqrt = new IsSqrt();
        private CheckModulus checkMod = new CheckModulus();
        // opgave 1
        [Fact]
        public void TestAdd()
        {
            using var ctx = new TestContext();
            var calcAdd = ctx.RenderComponent<Calculator>();

            calcAdd.FindAll("input")[0].Change("2");
            calcAdd.FindAll("input")[1].Change("2");
            calcAdd.FindAll("button")[0].Click();

            calcAdd.FindAll("input")[2].GetAttribute("value").MarkupMatches("4");
        }

        [Fact]
        public void TestSubtract()
        {
            using var ctx = new TestContext();
            var calcSub = ctx.RenderComponent<Calculator>();

            calcSub.FindAll("input")[0].Change("5");
            calcSub.FindAll("input")[1].Change("3");
            calcSub.FindAll("button")[1].Click();

            calcSub.FindAll("input")[2].GetAttribute("value").MarkupMatches("2");
        }

        [Fact]
        public void TestMultiply()
        {
            using var ctx = new TestContext();
            var calcMult = ctx.RenderComponent<Calculator>();

            calcMult.FindAll("input")[0].Change("2");
            calcMult.FindAll("input")[1].Change("2");
            calcMult.FindAll("button")[2].Click();

            calcMult.FindAll("input")[2].GetAttribute("value").MarkupMatches("4");
        }

        [Fact]
        public void TestDivide()
        {
            using var ctx = new TestContext();
            var calcDiv = ctx.RenderComponent<Calculator>();

            calcDiv.FindAll("input")[0].Change("2");
            calcDiv.FindAll("input")[1].Change("2");
            calcDiv.FindAll("button")[3].Click();

            calcDiv.FindAll("input")[2].GetAttribute("value").MarkupMatches("1");
        }


        //Opgave 2
        [Fact]
        public void TestPrime()
        {
            using var ctx = new TestContext();
            var calcPrime = ctx.RenderComponent<Calculator>();
            var primeResult = "";

            calcPrime.FindAll("input")[0].Change("1");
            calcPrime.FindAll("input")[1].Change("2");
            calcPrime.FindAll("button")[0].Click();
            calcPrime.FindAll("button")[4].Click();
            calcPrime.FindAll("input")[3].Change(isPrime.IsNumberPrime(int.Parse(calcPrime.FindAll("input")[2].GetAttribute("value"))).ToString());

            calcPrime.FindAll("input")[2].GetAttribute("value").MarkupMatches("1");
            primeResult = calcPrime.FindAll("input")[3].GetAttribute("value");

            Assert.True(bool.Parse(primeResult));
        }

        [Fact]
        public void TestSquareRoot()
        {
            using var ctx = new TestContext();
            var calcSqrt = ctx.RenderComponent<Calculator>();
            var sqrtResult = "";
            var numberToSquare = "";

            calcSqrt.FindAll("input")[0].Change("4");
            calcSqrt.FindAll("button")[5].Click();
            calcSqrt.FindAll("input")[4].Change(isSqrt.IsNumberSqrt(int.Parse(calcSqrt.FindAll("input")[0].GetAttribute("value"))).ToString());

            sqrtResult = calcSqrt.FindAll("input")[4].GetAttribute("value");

            Assert.True(bool.Parse(sqrtResult));

        }

        [Fact]
        public void TestModulus()
        {
            using var ctx = new TestContext();
            var calcMod = ctx.RenderComponent<Calculator>();
            var modulusResult = "";

            calcMod.FindAll("input")[0].Change("2");
            calcMod.FindAll("input")[1].Change("2");
            calcMod.FindAll("button")[6].Click();
            calcMod.FindAll("input")[2].Change(checkMod.CheckModulusForNumbers(int.Parse(calcMod.FindAll("input")[0].GetAttribute("value")), int.Parse(calcMod.FindAll("input")[1].GetAttribute("value"))).ToString());

            calcMod.FindAll("input")[2].GetAttribute("value").MarkupMatches("2");
        }
    }
}
