using GrandpasSamagon.Controllers;
using GrandpasSamagon.Models;
using NUnit.Framework;
using System;

namespace GrandpasSamagonTests
{
    /// <summary>
    /// Represents a class for testing a SugarController.
    /// </summary>
    [TestFixture]
    public class SugarControllerTest
    {
        [Test]
        public void GetIndexesOfSortedArray()
        {
            var controller = new SugarController();
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 9;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = "3, 4";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetIndexesOfUnsortedArray()
        {
            var controller = new SugarController();
            int[] arr = { 5, 2, 4, 3, 1 };
            int sum = 9;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = "0, 2";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetIndexesOfArrayWithRepeatedNumbersInBeginning()
        {
            var controller = new SugarController();
            int[] arr = { 1,1,2 };
            int sum = 2;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = "0, 1";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetIndexesOfArrayWithRepeatedNumbers()
        {
            var controller = new SugarController();
            int[] arr = { 1, 6, 2, 3, 3, 7, 1 };
            int sum = 2;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = "0, 6";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetIndexesOfArrayWithRepeatedNumbersInCenter()
        {
            var controller = new SugarController();
            int[] arr = { 1, 6, 2, 3, 3, 7, 1 };
            int sum = 6;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = "3, 4";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAbsentIndexes()
        {
            var controller = new SugarController();
            int[] arr = { 1, 6, 2, 3, 3, 7, 1 };
            int sum = 99;

            string actualResult = controller.GetIndexes(arr, sum);
            string expectedResult = string.Empty;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
