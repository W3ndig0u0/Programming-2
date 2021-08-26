using System;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      yo yo1 = new yo();

      string yooo = yo1.yoo;
      Console.WriteLine(yooo);
      Console.WriteLine("Är det sant?");

      Console.WriteLine(yo1.yooQuestion);

      Console.ReadKey();


    }
  }
}

