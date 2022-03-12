namespace AbstractFactoryPatterns
{
  class NavigationBar
  {
    public NavigationBar(IUIFactory factory) => factory.CreateButton();
  }
}