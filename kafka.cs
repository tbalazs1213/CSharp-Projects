using System;
using System.Threading;

class MainClass 
{
  public static void Main (string[] args) 
  {
    string nev = "Franz Kafka: Atvaltozas\n\nAmikor egy reggel Gregor Samsa nyugtalan almabol felebredt, szornyu feregge valtozva talalta magat agyaban. Pancelszeruen kemeny hatan fekudt, és ha kisse folemelte a fejet, meglatta domboru, barna, iv alaku, kemeny szelvenyekkel izelt hasat, amelyen alig maradt mar meg vegleg lecsuszni keszulo paplana. Szamtalan, testenek egyeb mereteihez kepest siralmasan vekony laba tehetetlenul kapalodzott szeme elott.";
    Console.Clear();
    for (int i = 0; i < nev.Length; i++)
    {
      Console.Write(nev[i]);
      if (nev[i] == '.')
      {
        Thread.Sleep(400);
      }
      Thread.Sleep(200);
      Console.Beep();
    }
  }
}
