using System;
using System.Threading;

class MainClass 
{
  public static void Main (string[] args) 
  {
    for (int i = 0;; i++)
    {
      Console.Clear();
      Console.Write("");
      Thread.Sleep(500);
      Console.Clear();
      Console.Write('.');
      Thread.Sleep(500);
      Console.Clear();
      Console.Write("..");
      Thread.Sleep(500);
      Console.Clear();
      Console.Write("...");
      Thread.Sleep(500);
    }
  }
}
