using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemA.Tests
{
   [TestClass]
   [SuppressMessage("ReSharper", "ArgumentsStyleLiteral")]
   [SuppressMessage("ReSharper", "ArgumentsStyleNamedExpression")]
   [SuppressMessage("ReSharper", "ArgumentsStyleOther")]
   public class ProblemATests
   {
      [TestMethod]
      public void SampleInputOneReturnsTrue()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(peopleLeft: 0, peopleEntered: 1, peopleStayed: 1), new Measurement(peopleLeft: 1, peopleEntered: 0, peopleStayed: 0)};
         var checker = new CapacityChecker(capacity: capacity, numberOfStations: numberOfStations, measurements: measurements);

         Assert.IsTrue(condition: checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputTwoReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(peopleLeft: 1, peopleEntered: 0, peopleStayed: 0), new Measurement(peopleLeft: 0, peopleEntered: 1, peopleStayed: 0)};
         var checker = new CapacityChecker(capacity: capacity, numberOfStations: numberOfStations, measurements: measurements);

         Assert.IsFalse(condition: checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputThreeReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(peopleLeft: 0, peopleEntered: 1, peopleStayed: 0), new Measurement(peopleLeft: 1, peopleEntered: 0, peopleStayed: 1)};
         var checker = new CapacityChecker(capacity: capacity, numberOfStations: numberOfStations, measurements: measurements);

         Assert.IsFalse(condition: checker.IsPossibble());
      }

      [TestMethod]
      public void SampleInputFourReturnsFalse()
      {
         const int capacity = 1;
         const int numberOfStations = 2;
         var measurements = new List<Measurement> {new Measurement(peopleLeft: 0, peopleEntered: 1, peopleStayed: 1), new Measurement(peopleLeft: 0, peopleEntered: 0, peopleStayed: 0)};
         var checker = new CapacityChecker(capacity: capacity, numberOfStations: numberOfStations, measurements: measurements);

         Assert.IsFalse(condition: checker.IsPossibble());
      }
   }
}