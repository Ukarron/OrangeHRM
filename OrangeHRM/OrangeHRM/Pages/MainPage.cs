namespace OrangeHRM.Pages
{
    public class MainPage : AbstractPage<MainPage_Selectors>
    {
        private PersonalMenu _personalMenu;
        private Menu _menu;

        public MainPage() 
            : base(new MainPage_Selectors()) {}

        public PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu();
        public Menu Menu => _menu = new Menu();
    }

    public class MainPage_Selectors
    {
    }
}
