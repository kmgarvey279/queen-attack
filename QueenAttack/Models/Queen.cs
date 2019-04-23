using System;

namespace QueenSpace {
  public class Queen{ // class
    public int QueenX;
    public int QueenY;

  public Queen()
  // (int queenX, int queenY)
    {
    QueenX=4;
    QueenY=4;
    }

  public bool CanAttack(int userX, int userY) // method
{
    if(QueenX == userX || QueenY == userY)
    {
      return true;
    }
    else
    {
      int xDiagonal = QueenX - userX;
      int yDiagonal = QueenY - userY;
      if (xDiagonal / yDiagonal == 1 ||  xDiagonal / yDiagonal == -1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

}
}



// // public class Program
// // {
// //   public static void Main()
// //   {
// //     Console.WriteLine("Please enter X coordinate of your piece");
// //     int userCoordinateX = int.Parse(Console.ReadLine());
// //     Console.WriteLine("Please enter Y coordinate of your piece");
// //     int userCoordinateY = int.Parse(Console.ReadLine());
// //     Queen myCoord = new Queen (userCoordinateX, userCoordinateY);
// //   }
// // }
// }
