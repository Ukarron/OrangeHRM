namespace OrangeHRM.Pages
{
    public class MainPage : AbstractPage<MainPage_Selectors>
    {
        private PersonalMenu _personalMenu;
        private Menu _menu;

        public MainPage(Pages h) 
            : base(h, new MainPage_Selectors()) {}


        public PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu(this.pages);
        public Menu Menu => _menu = new Menu(this.pages);
    }

    public class MainPage_Selectors
    {
    }
}
