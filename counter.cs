using System;
using System.Threading;

class MainClass 
{
  public static void Main (string[] args) 
  {
    for (int i = 0; ; i++)
    {
      Console.Clear();
      Console.WriteLine(i);
      Thread.Sleep(1000);
    }
  }
}
