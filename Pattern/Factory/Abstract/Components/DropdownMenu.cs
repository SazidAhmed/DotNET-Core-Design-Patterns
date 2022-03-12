namespace AbstractFactoryPatterns
{
  class DropdownMenu
  {
	  public DropdownMenu(IUIFactory factory) => factory.CreateButton();
  }
}