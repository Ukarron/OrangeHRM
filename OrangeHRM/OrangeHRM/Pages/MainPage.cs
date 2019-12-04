namespace OrangeHRM.Pages
{
    public class MainPage : AbstractPage<MainPage_Selectors>
    {
        private PersonalMenu _personalMenu;

        public MainPage() 
            : base(new MainPage_Selectors()) {}

        public PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu();
    }

    public class MainPage_Selectors
    {

    }
}
