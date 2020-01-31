using OpenQA.Selenium;
using OrangeHRM.Pages.Components;

namespace OrangeHRM.Pages
{
    public abstract class MainPage<T> : AbstractPage<T> where T : MainPage_Selectors
    {
        private PersonalMenu _personalMenu;
        private Menu _menu;

        public MainPage(Pages p, T type) 
            : base(p, type){}

        public void ClickMarketplaceButton()
        {
            page.UIInteraction.Click(Selectors.MarketplaceButton);
        }

        public void ClickLogo()
        {
            page.UIInteraction.Click(Selectors.OrangeHRMLogo);
        }

        public PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu(this.page);
        public Menu Menu => _menu = new Menu(this.page);
    }

    public class MainPage_Selectors
    {
        public By MarketplaceButton = By.Id("MP_link");
        public By OrangeHRMLogo = By.CssSelector("#branding img");
    }
}
