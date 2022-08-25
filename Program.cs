namespace Pathfinder;

public class Pathfinder
{

  public int findPaths(int[,] street, int start_i, int start_j, int acc)

  {

    for (int i = start_i; i < street.GetLength(0); i++) // iterate horizontal
    { 
      for (int j = start_j; j < street.GetLength(1); j++)  // iterate vertical
      {
        if (i == 2 && j == 2)
        {
          return acc + 1;  // reach exit block
        }
        else if (street[i, j] == 0 || i + 1 >= street.GetLength(0)) //TODO: not sure i+1
        {
          return acc;
        }
        else
        {
          acc = findPaths(street, i + 1, j, acc); //move down
        }
      }
    }
    return acc;
  }
  public static void Main()
  {
    int[,] map0 = new int[3, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
    int[,] map1 = new int[3, 3] { { 1, 1, 1 }, { 0, 1, 1 }, { 1, 1, 1 } };
    Pathfinder p = new Pathfinder();
    Console.Out.WriteLine("number of paths on map0: " + p.findPaths(map0, 0, 0, 0));
    Console.Out.WriteLine("number of paths on map1: " + p.findPaths(map1, 0, 0, 0));
  }
}