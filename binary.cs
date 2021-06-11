using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.Clear();
    int beszam;
    int oszto = 128;
    string eredmeny = "";
    do 
    {
      Console.Write("Atvaltando szam (max.: 255): ");
      beszam = Convert.ToInt32(Console.ReadLine());
      if (beszam >= 256)
      {
        Console.WriteLine("###");
      }
    } while(beszam >= 256);
    for (int i = 0; i < 8; i++)
    {
      if (beszam / oszto == 1)
      {
        eredmeny = eredmeny + '1';
        beszam = beszam - oszto;
      }
      else
      {
        eredmeny = eredmeny + '0';
      }
      oszto /= 2;
    }
  Console.WriteLine("Eredmeny:        {0}",Convert.ToInt32(eredmeny));
  }
}
