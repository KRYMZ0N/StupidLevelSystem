using System;

class Program {
  private int i = 1;
  private int level = 0;
  private int xp = 0;
  public static void Main (string[] args) {
    String input = Console.ReadLine();
    Program p = new Program();
    
    while (p.isOn()) {
      if (input.Equals("eat")) {
        p.xp = p.xp + 1;

        switch (p.xp) {  // Goes through xp to level up
          case 10: 
          p.level = 1;
          Console.WriteLine("Congratulations! You are now level" + p.format(p.level));
          input = Console.ReadLine();
          break;

          case 20:
          p.level = 2;
          Console.WriteLine("Congratulations! You are now level" + p.format(p.level));
          input = Console.ReadLine();
          break;

          case 40:
          p.level = 3;
          Console.WriteLine("Congratulations! You are now level" + p.format(p.level));
          input = Console.ReadLine();
          break;
        
          default:
          int a = p.toNextLevel();
          Console.WriteLine("You are level: " + p.format(p.level));
          Console.WriteLine("You currently need: " + p.format(a));
          input = Console.ReadLine();
          break;
        }
      } else {
        Console.WriteLine("try writing 'eat' instead");
        input = Console.ReadLine();
      }
    }
  }

  private bool isOn() { // Game loop
    if (i == 1) {
      return true;
    } else {
      return false;
    }
  }

  private String format(int x) { // Takes integers and turns them into String value.
     return x.ToString();
  }

  private int toNextLevel() { // Method to find how much xp to the next level.
    if (level == 0) {
      return 10 - xp;
    } else {

      if (level == 1) {
        return 20 - xp;
      } else {

        if (level == 2) {
          return 40 - xp;
        } else {
          if (level == 3) {
            return 9;
          } else {
            return 0;
          }
        }
      }
    }
  }
}