using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    WriteLine(IsPrime(27644437));
  }
  public static bool IsPrime (long num) {
    bool prime = true;
    if (num % 2 == 0 || num <= 1) {
      return prime = false;
    }
    int i = 2;
    while (i < num) {
      if (num % i == 0) {
          prime = false;
          break;
        }
      else if (i > (num/2)) {
        break;
      }
      i += 2;
    }
    return prime;
  }
}