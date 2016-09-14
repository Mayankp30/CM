using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CampaignMonitor.Tests
{
    [TestClass()]
    public class MainClassTests
    {
        [TestMethod()]
        public void isNullorEmptyTest(){

            string s = null;

            //IsNullOrEmpty
            Assert.AreEqual(true, string.Empty.IsNullOrEmpty());
            Assert.AreEqual(true, s.IsNullOrEmpty());
            Assert.AreEqual(false, "null".IsNullOrEmpty());
            Assert.AreEqual(false, "a".IsNullOrEmpty());
            Assert.AreEqual(true, "".IsNullOrEmpty());
        }

        [TestMethod()]
        public void calculateTArea_MatchesRightOutputTest()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            double ExpectedOutput = 6.0;

            //Calculate Triangle Area
            Assert.AreEqual(ExpectedOutput, MainClass.calculateTArea(sideA, sideB, sideC));
            
        }


        [TestMethod()]
        public void calculateTArea_InvalidInputTest()
        {
            int sideA = 7;
            int sideB = 2;
            int sideC = 2;


            try
            {
                 MainClass.calculateTArea(sideA, sideB, sideC);
                // If this pass without exception then throw fail
                Assert.Fail("Exception case not handled correctly by the method. Please Check the method for exception scenario where sides do not make a triangle.");
            }
            catch (Exception exception)
            {
                Assert.IsInstanceOfType(exception, typeof(InvalidTriangleException));

            }
        }



        [TestMethod()]
        public void calculateTArea_NegativeInputTest()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = -5;


            try
            {
                MainClass.calculateTArea(sideA, sideB, sideC);
                // If this pass without exception then throw fail
                Assert.Fail("Exception case not handled correctly by the method. Please Check the method for exception scenario where sides do not make a triangle.");
            }
            catch (Exception exception)
            {
                Assert.IsInstanceOfType(exception, typeof(InvalidTriangleException));

            }
        }


        [TestMethod()]
        public void getDivisorsTest()
        {
        
            //GetDivisors
            Assert.AreEqual("1", String.Join(",", MainClass.getDivisors(1)));
            Assert.AreEqual("1,2,5,10", String.Join(",", MainClass.getDivisors(10)));
            Assert.AreEqual("1,2,3,4,5,6,10,12,15,20,30,60", String.Join(",", MainClass.getDivisors(60)));
            Assert.AreEqual("1,2,3,6,7,14,21,42", String.Join(",", MainClass.getDivisors(42)));
        }


        [TestMethod()]
        public void getMostCommonUsedNumberTest()
        {

            //Most Common
            int[] arrayInput = new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            int[] arrayResult = new int[] { 5, 4 };
            Assert.AreEqual(String.Join(",", arrayResult), String.Join(",", MainClass.getMostCommonUsedNumber(arrayInput)));

        }



        [TestMethod()]
        public void getMostCommonUsedNumber_AllNumbersSameFrequencyTest()
        {

            //Most Common
            int[] arrayInput = new int[] { 1,2,3,4,5,1,2,3,4,5 };
            int[] arrayResult = new int[] { 1, 2,3,4,5 };
            Assert.AreEqual(String.Join(",", arrayResult), String.Join(",", MainClass.getMostCommonUsedNumber(arrayInput)));

        }


    }
}