namespace ProblemA
{
   public class Measurement
   {
      private int _peopleLeft;
      private int _peopleEntered;
      private int _peopleStayed;

      public Measurement(int peopleLeft, int peopleEntered, int peopleStayed)
      {
         _peopleLeft = peopleLeft;
         _peopleEntered = peopleEntered;
         _peopleStayed = peopleStayed;
      }
   }
}