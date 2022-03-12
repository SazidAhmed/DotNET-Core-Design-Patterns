namespace FactoryPatterns
{
  class ButtonFactory
  {
    public static Button CreateButton(){
      return new Button {Type = "Red Button"};
    }
  }
}