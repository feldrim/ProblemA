using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemA.Tests
{
   [TestClass]
   public class ProblemATests
   {
      [TestMethod]
      public void SampleInputOneReturnsTrue()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(0, 1, 1), new Measurement(1, 0, 0)};
         var checker = new CapacityChecker(capacity, numberOfStations, measurements);

         Assert.IsTrue(checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputTwoReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(1, 0, 0), new Measurement(0, 1, 0)};
         var checker = new CapacityChecker(capacity, numberOfStations, measurements);

         Assert.IsFalse(checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputThreeReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(0, 1, 0), new Measurement(1, 0, 1)};
         var checker = new CapacityChecker(capacity, numberOfStations, measurements);

         Assert.IsFalse(checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputFourReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(0, 1, 1), new Measurement(0, 0, 0)};
         var checker = new CapacityChecker(capacity, numberOfStations, measurements);

         Assert.IsFalse(checker.IsPossibble());
      }
   }
}