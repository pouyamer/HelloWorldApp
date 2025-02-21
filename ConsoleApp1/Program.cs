

namespace helloworldapp {
  class App {

    private void ToggleErrorMode(bool toggle) {
      // Add a map, to save the previous state
      if (toggle) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
      }
    }

    static void Main(string[] args) {
      Console.BackgroundColor = ConsoleColor.DarkYellow;

      Console.ForegroundColor = ConsoleColor.Black;

      Console.SetWindowSize(100, 500);

      if (OperatingSystem.IsWindows()) {
        bool isCapsLockOn = Console.CapsLock;

        Console.WriteLine("CapsLock is {0}", isCapsLockOn ? "ON" : "OFF");
      }

      Console.WriteLine("Hello World");

      // nullable syntax
      int input1 = 0;

      do {
        Console.Write("Please Enter Your Age: ");

        try {
          input1 = int.Parse(Console.ReadLine() ?? "0");

          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.BackgroundColor = ConsoleColor.Black;


          if (input1 <= 0) {
            Console.WriteLine("Invalid Age number");
            continue;
          }

        }
        catch (FormatException) {
          Console.WriteLine("Wrong Format! Please use numbers!");

          input1 = -1;
        }
        catch (OverflowException) {
          Console.WriteLine("Number too Large or too Small");

          input1 = -1;
        }

        // I learnt that finally block runs regardless of wether it is caught or not


        if (input1 < 18) Console.WriteLine("Age CANNOT be less than '18'\n");

      } while (input1 < 18);



      Console.WriteLine("Your number is {0}", input1);

    }
  }
}

