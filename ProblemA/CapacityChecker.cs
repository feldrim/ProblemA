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
         if (capacity <= 0 || capacity >= 1000000000)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be between 1 and 10^9");

         if (numberOfStations < 2 || numberOfStations > 100)
            throw new ArgumentException("Number of stations must be between 2 amd 100.", nameof(numberOfStations));

         if (measurements == null)
            throw new ArgumentNullException(nameof(measurements), "Measurements cannot be null.");

         if (measurements.Count != numberOfStations)
            throw new ArgumentException("Number of stations are different than given measurements data.",
               nameof(numberOfStations));

         _capacity = capacity;
         _measurements = measurements;
      }

      public bool IsPossibble()
      {
         var passengersOnTrain = 0;

         foreach (var measurement in _measurements)
         {
            passengersOnTrain -= measurement.PeopleLeft;
            if (passengersOnTrain < 0) return false;

            passengersOnTrain += measurement.PeopleEntered;
            if (passengersOnTrain > _capacity) return false;

            var emptySeats = _capacity - passengersOnTrain;
            if (emptySeats > 0 && measurement.PeopleStayed > 0) return false;
         }

         return passengersOnTrain == 0;
      }
   }
}