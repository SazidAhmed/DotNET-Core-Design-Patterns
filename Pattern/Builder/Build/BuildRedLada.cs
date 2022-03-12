
namespace BuilderPatterns
{
  class RedLada
  {
    public static void BuildRedLada1980(ICarBuilder builder){
        builder
            .setMake("lada")
            .setColor("red")
            .setManifactureDate("1980");
    }
  }
}