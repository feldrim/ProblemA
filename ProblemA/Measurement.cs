namespace ProblemA
{
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
}