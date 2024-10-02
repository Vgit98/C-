using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x=0, int y=0)
    {
      return x;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(y:5));
    }
  }
}