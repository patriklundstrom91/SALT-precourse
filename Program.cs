using System;

namespace snallWeeks_lab_firstDotNetApp
{
  class Program
  {
    private static string greet(string namePassedIn)
    {
      return "Welcome to SALT, ";
    }
    static void Main(string[] args)
    {
      Console.Write("What is your name? ");
      var name = Console.ReadLine();

      var greeting = greet(name);

      Console.WriteLine(greeting);
    }
  }
}
