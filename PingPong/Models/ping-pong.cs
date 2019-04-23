using System;

namespace PingPongGame
{
  public class PingPong
  {
    // static void Main()
    // {
      // int userInput = int.Parse(Console.ReadLine());
      public bool IsPing(int number)
      {
        return number % 3 == 0;
      }
      public bool IsPong(int number)
      {
        return number % 5 == 0;
      }
      public bool IsPingPong(int number)
      {
        return number % 3 == 0 && number % 5 == 0;
      }
      // for (i = 0; i <= userInput; i++) {
      //   if(i % 3 == 0 && i % 5 == 0)
      //   {
      //     Console.WriteLine("ping-pong");
      //   }
        // else if (i % 5 ==0)
        // {
        //   Console.WriteLine("pong");
        // }
        // else if (i % 3 == 0)
        // {
        //   Console.WriteLine("ping");
        // }
        // else
        // {
        //
        // }
      // }
    }
  }
// }
