namespace FactoryPatterns
{
  class NavigationBar
  {
    public NavigationBar() => ButtonFactory.CreateButton();
  }
}