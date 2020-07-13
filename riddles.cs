using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Random rnd = new Random();

    string[,] qAndA = new string[,] {{"What color is an orange?", "orange"}, {"How many feet in a yard?", "3"}, {"What is the square root of 25?", "5"}};
    int randomIndex = rnd.Next(0, (qAndA.Length / 2));
    // Console.WriteLine(randomIndex.ToString());
    List<int> indexLog = new List<int>();
    indexLog.Add(randomIndex);

    Console.WriteLine("Welcome to the riddle of the sphinx!");
    Console.WriteLine("Please enter an answer to the provided question below.");

    while (indexLog.Count <= (qAndA.Length / 2)) 
    {
      Console.WriteLine(randomIndex.ToString());
      Console.WriteLine(qAndA[randomIndex, 0]);
      string answer = Console.ReadLine();

      if (answer.ToLower() == qAndA[randomIndex, 1])
      {
        Console.WriteLine("Correct");
      }
      else
      {
        Console.WriteLine("Incorrect");
        Console.WriteLine("Goodbye");
        break;
      }

      while (indexLog.Contains(randomIndex) && indexLog.Count < (qAndA.Length / 2))
      {
        Console.WriteLine(randomIndex.ToString());
        randomIndex = rnd.Next(0, (qAndA.Length / 2));
      }
      indexLog.Add(randomIndex);
    }
  }

}

// if (indexLog.Contains(0))
// {
//   randomIndex = rnd.Next(0, (qAndA.Length / 2) - 1);
//   Console.WriteLine(randomIndex.ToString());
//   Console.WriteLine(qAndA[randomIndex, 0]);
//   string answer = Console.ReadLine();
// } else (indexLog.)