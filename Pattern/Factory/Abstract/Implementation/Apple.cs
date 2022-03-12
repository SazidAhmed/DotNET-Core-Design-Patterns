namespace AbstractFactoryPatterns
{
  class Apple : IUIFactory{
    public Button CreateButton()
    {
      return new Button { Type = "iOS Button" };
    }
  }
}