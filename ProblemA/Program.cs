using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemA
{
   public partial class Program
   {
      public static void Main(string[] args)
      {
         if (args == null || !args.Any()) return;
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
   }
}