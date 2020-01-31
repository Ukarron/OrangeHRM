using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class UsersPage : AbstractPage<UsersPage_Selectors>
    {
        public UsersPage(Pages p) 
            : base(p, new UsersPage_Selectors()){}

        public void ClickAddButton()
        {
            page.UIInteraction.Click(Selectors.AddButton);
        }
    }

    public class UsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
    }
}
