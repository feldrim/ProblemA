using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemA
{
   public class Program
   {
      public static void Main()
      {


         var content = new List<string>();
         string line; 
         while ((line = Console.ReadLine()) != null) {
            content.Add(line);
         } 

         var capacity = int.Parse(content[0].Split(' ')[0]);
         var numberOfStations = int.Parse(content[0].Split(' ')[1]);
         var measurements = new List<Measurement>();

         for (var i = 1; i < content.Count(); i++)
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
