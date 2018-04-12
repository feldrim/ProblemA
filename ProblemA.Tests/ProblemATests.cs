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
         var measurements = new List<Measurement> { new Measurement(0, 1, 1), new Measurement(1, 0, 0) };
         const int capacity = 1;
         var checker = new CapacityChecker(capacity);
         Assert.IsTrue(checker.IsPossibble(measurements));
      }
   }
}
