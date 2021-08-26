using System;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Yo Yo1 = new Yo();

      string yooo = Yo1.yoo;
      Console.WriteLine(yooo);
      Console.WriteLine("Är det sant?");

      Console.WriteLine(Yo1.yooQuestion);

      Console.ReadKey();


    }
  }
}

