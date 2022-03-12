using System;
  
namespace BuilderPatterns
{
  class Program  
  {
    static void Main_exe(string[] args)  
    {
      Console.WriteLine("========== Builder Pattern ==========");
      var builder = new CarBuilder();
      RedLada.BuildRedLada1980(builder);
      Console.WriteLine(builder.Build());
    }  
  }
}