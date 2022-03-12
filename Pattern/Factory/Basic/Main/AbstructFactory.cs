namespace AbstructFactory
{
    public class DropdownMenu
    {
        public NavigationBar(IUIFactory factory) => factory.CreateButton();
    }

    public class NavigationBar
    {
        public DropdownMenu(IUIFactory factory) => factory.CreateButton();
    }

    public interface IUIFactory
    {
        public Button CreateButton();

        public Button CreateButton();
    }

    public class Apple : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "iOS Button".Dump() };
        }
    }

    public class Android : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "Android Button".Dump() };
        }
    }

    public class Button
    {
        public string Type { get; set; }
    }
}