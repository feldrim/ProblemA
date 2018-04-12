using System;
using System.Collections.Generic;
using System.IO;

namespace ProblemA
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var path = args[0];
         var content = File.ReadAllLines(path);

         var capacity = int.Parse(content[0].Split(' ')[0]);
         var numberOfStations = int.Parse(content[0].Split(' ')[1]);
         var measurements = new List<Measurement>();

         for (var i = 1; i < content.Length; i++)
         {
            var peopleLeft = int.Parse(content[i].Split(' ')[0]);
            var peopleEntered = int.Parse(content[i].Split(' ')[1]);
            var peopleStayed = int.Parse(content[i].Split(' ')[2]);

            measurements.Add(new Measurement(peopleLeft, peopleEntered, peopleStayed));
         }

         var capacityChecker = new CapacityChecker(capacity, numberOfStations, measurements);
         Console.WriteLine(capacityChecker.IsPossibble() ? "Possible" : "Impossible");
      }

      public class Measurement
      {
         public Measurement(int peopleLeft, int peopleEntered, int peopleStayed)
         {
            PeopleLeft = peopleLeft;
            PeopleEntered = peopleEntered;
            PeopleStayed = peopleStayed;
         }

         public int PeopleLeft { get; }

         public int PeopleEntered { get; }

         public int PeopleStayed { get; }
      }

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
}