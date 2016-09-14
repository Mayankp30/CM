using Microsoft.VisualStudio.TestTools.UnitTesting;
using CampaignMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor.Tests
{
    [TestClass()]
    public class UtilTests
    {
        [TestMethod()]
        public void getMostCommonUsedNumberTest()
        {
            var c = new Util();
            int[] intArr = new int[] { 1, 1, 2, 2, 3, 4, 4, 4, 4, 4, 5 };

            // Write more tests....  some returning more than 1
            int[] arr = c.getMostCommonUsedNumber(intArr);

            Assert.IsTrue(arr[0] == 4);
        }

        [TestMethod()]
        public void calculateTAreaTest()
        {
            var c = new Util();
           double d = c.calculateTArea(2, 3, 4);

            Assert.IsTrue(d == 4);// correct these things and run for negative numbers and stuff  
        }
    }
}