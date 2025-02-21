using System;

namespace HelloWorldApp {
  class App {
    static void Main(string[] args) {
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.SetWindowSize(100, 500);
      Console.WriteLine("Hello World");

    }
  }
}

