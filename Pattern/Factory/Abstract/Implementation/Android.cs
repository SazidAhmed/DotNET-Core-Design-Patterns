namespace AbstractFactoryPatterns
{
  class Android : IUIFactory{
    public Button CreateButton()
	{
		return new Button { Type = "Android Button" };
	}
  }
}