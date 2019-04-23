using System;
using System.Collections.Generic;

namespace PingPongGame
{
  public class PingPong
  {
    public List<string> ConvertToPingPong(int number)
    {
      List<string> numberList = new List<string>();
      for (int i = 1; i <= number; i++)
      {
        if(number % 3 == 0 && number % 5 == 0)
        {
          Console.WriteLine("pingpong");
          numberList.Add("ping pong");
        }
        else if(number % 3 == 0)
        {
          Console.WriteLine("pingpingpingping");
          numberList.Add("ping");
        }
        else if (number % 5 == 0)
        {
          Console.WriteLine("hello");
          numberList.Add("pong");
        }
        else
        {
          numberList.Add(i.ToString());
        }
      }
      return numberList;
    }

      //
      // public string IsPing(int number)
      // {
      //   string output = "ping";
      //   if(number % 3 == 0)
      //   {
      //     return output;
      //   }
      //   else
      //   {
      //     return number.ToString();
      //   }
      // }
      //
      // public string IsPong(int number)
      // {
      //   string output = "pong";
      //   if(number % 5 == 0)
      //   {
      //     return output;
      //   }
      //   else
      //   {
      //     return number.ToString();
      //   }
      // }
      //
      // public string IsPingPong(int number)
      // {
      //   string output = "ping pong";
      //   if(number % 3 == 0 && number % 5 == 0)
      //   {
      //     return output;
      //   }
      //   else
      //   {
      //     return number.ToString();
      //   }
      // }
      //
      // public List<string> PingPongList(int number)
      // {
      //   List<string> numberList = new List<string>();
      //   for (int i = 1; i <= number; i++)
      //   {
      //     string output = i.ToString();
      //     if (output == i.ToString()) output = IsPingPong(i);
      //     if (output == i.ToString()) output = IsPong(i);
      //     if (output == i.ToString()) output = IsPing(i);
      //     numberList.Add(output);
      //   }
      //   return numberList;
      // }

      // public List<string> PingPongList(int number)
      // {
      //   List<string> numberList = new List<string>();
      //   for (int i = 1; i <= number; i++)
      //     if(i % 3 == 0 && i % 5 == 0)
      //     {
      //       return i;
      //     }
      //     else if (i % 5 ==0)
      //     {
      //       return "pong";
      //     }
      //     else if (i % 3 == 0)
      //     {
      //       return "ping";
      //     }
      //     else
      //     {
      //       return i.ToString();
      //     }
      // }
  }
}
