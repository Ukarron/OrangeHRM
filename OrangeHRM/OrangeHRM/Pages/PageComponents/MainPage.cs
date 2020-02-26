using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;

namespace OrangeHRM.Pages.PageComponents
{
    public abstract class MainPage<T> : AbstractPage<T> where T : MainPage_Selectors
    {
        private PersonalMenu _personalMenu;
        private Menu _menu;

        public MainPage(AppManager p, T type) 
            : base(p, type){}

        public void ClickMarketplaceButton()
        {
            appManager.UIInteraction.Click(Selectors.MarketplaceButton);
        }

        public void ClickLogo()
        {
            appManager.UIInteraction.Click(Selectors.OrangeHRMLogo);
        }

        public PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu(this.appManager);
        public Menu Menu => _menu = new Menu(this.appManager);
    }

    public class MainPage_Selectors
    {
        public By MarketplaceButton = By.Id("MP_link");
        public By OrangeHRMLogo = By.CssSelector("#branding img");
    }
}
