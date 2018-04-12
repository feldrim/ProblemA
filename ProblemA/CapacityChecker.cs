using System;
using System.Collections.Generic;

namespace ProblemA
{
   public class CapacityChecker
   {
      private readonly int _capacity;
      private readonly List<Measurement> _measurements;

      public CapacityChecker(int capacity, int numberOfStations, List<Measurement> measurements)
      {
         if (measurements.Count == numberOfStations)
            _measurements = measurements;
         else
            throw new ArgumentException("Number of stations are different than given measurements data.",
               nameof(numberOfStations));

         if (capacity > 0 && capacity < 1000000000)
            _capacity = capacity;
         else
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be between 1 and 10^9");
      }

      public bool IsPossibble()
      {
         var passengersOnTrain = 0;

         foreach (var measurement in _measurements)
         {
            passengersOnTrain += measurement.PeopleEntered;
            if (passengersOnTrain > _capacity) return false;

            passengersOnTrain -= measurement.PeopleLeft;
            if (passengersOnTrain < 0) return false;
         }

         return passengersOnTrain <= 0;
      }
   }
}