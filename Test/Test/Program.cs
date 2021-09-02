using System;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Yo Yo1 = new Yo();
      Player player = new Player();


      string yooo = Yo1.yoo;
      player.name = "Bob The builder";
      player.maxHp = 100;
      player.currHp = 80;
      player.dmg = 12;
      player.currHoldingInv = 1;
      player.currAmountInv = 2;
      player.currAmountInvName = "Sword";
      player.maxInv = 3;
      player.inAir = false;
      player.runningAvailable = true;
      player.powerAvailable = true;
      player.jumpingAvailable = true;


      // Console.WriteLine(yooo);
      // Console.WriteLine("Är det sant?");
      // Console.WriteLine(Yo1.yooQuestion);

      Console.WriteLine($"Name: {player.name}");
      Console.WriteLine($"Health: {player.currHp} / {player.maxHp} hp");
      Console.WriteLine($"Currently Holding Inventory Nr: {player.currHoldingInv},  {player.currAmountInvName} {player.dmg} dmg");
      Console.WriteLine($"Current Amount of Inventory: {player.currAmountInv}");
      Console.WriteLine($"Max Inventory: {player.maxInv}");
      Console.WriteLine($"Currently in the air: {player.inAir}");
      Console.WriteLine($"Running Avalible: {player.runningAvailable}");
      Console.WriteLine($"Jumping Avalible: {player.jumpingAvailable}");
      Console.WriteLine($"Special Powers Avalible: {player.powerAvailable}");
      Console.ReadKey();

    }
  }
}

