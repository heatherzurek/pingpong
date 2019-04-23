using System;
using System.Collections.Generic;

namespace PingPongGame
{
  public class PingPongUI
  {
    static void Main()
    {
      Console.WriteLine("Enter a number :");
      int number = int.Parse(Console.ReadLine());
      PingPong pingPong = new PingPong();

      List<string> output = new List<string>(pingPong.ConvertToPingPong(number));
      // output = pingPong.ConvertToPingPong(number);
      // Console.WriteLine(output);
      foreach (string item in output)
      {
        Console.WriteLine(item);
    }
    }
  }
}
