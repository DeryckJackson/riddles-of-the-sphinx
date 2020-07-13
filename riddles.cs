using System;

class Program
{
  static void Main()
  {
    string[] questions = {"What color is an orange?", "How many feet in a yard?"};
    string[] answers = {"orange", "3"};

    Console.WriteLine("Welcome to the riddle of the sphinx!");
    Console.WriteLine("Please enter an answer to the provided question below.");
    Console.WriteLine(questions[0]);

    string answer = Console.ReadLine();

    if (answer.ToLower() == answers[0])
    {
      Console.WriteLine("Correct");
      Console.WriteLine(questions[1]);

      string answer2 = Console.ReadLine();
      if (answer2.ToLower() == answers[1])
      {
        Console.WriteLine("Correct!");
      }
      else 
      {
        Console.WriteLine("Incorrect");
        Console.WriteLine("Goodbye");
      }
    }
    else
    {
      Console.WriteLine("Incorrect");
      Console.WriteLine("Goodbye");
    }
  }
}

//int month  = rnd.Next(1, 13);