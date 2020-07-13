using System;

class Program
{
  static void Main()
  {
    string[,] qAndA = new string[,] {{"What color is an orange?", "orange"}};


    Console.WriteLine("Welcome to the riddle of the sphinx!");
    Console.WriteLine("Please enter an answer to the provided question below.");
    Console.WriteLine(qAndA[0, 0]);

    string answer = Console.ReadLine();

    if (answer.ToLower() == qAndA[0,1])
    {
      Console.WriteLine("Correct");
      // Console.WriteLine(questions[1]);

      // string answer2 = Console.ReadLine();
      // if (answer2.ToLower() == answers[1])
      // {
      //   Console.WriteLine("Correct!");
      // }
      // else 
      // {
      //   Console.WriteLine("Incorrect");
      //   Console.WriteLine("Goodbye");
      // }
    }
    else
    {
      Console.WriteLine("Incorrect");
      Console.WriteLine("Goodbye");
    }
  }
}

//int month  = rnd.Next(1, 13);