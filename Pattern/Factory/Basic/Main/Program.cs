using System;
  
namespace FactoryPatterns
{
  class Program  
  {
    static void Main_exe(string[] args)  
    {
      Console.WriteLine("========== Factory Pattern ==========");
      new NavigationBar();
      new DropdownMenu();
    }  
  }
}