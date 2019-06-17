using System;
namespace  QueenSpace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter X coordinate of your piece");
      int userCoordinateX = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter Y coordinate of your piece");
      int userCoordinateY = int.Parse(Console.ReadLine());
      Queen myCoord = new Queen ();
      bool res = myCoord.CanAttack(userCoordinateX, userCoordinateY);
      Console.WriteLine ("You can be attacked" + res);
    }
  }
}
