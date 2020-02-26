using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;

namespace OrangeHRM.Pages.PageComponents
{
    public abstract class AddPage<T> : AbstractPage<T> where T : AddPage_Selectors
    {
        public AddPage(AppManager p, T type) 
            : base(p, type) {}

        [AllureStep]
        public void ClickSave()
        {
            appManager.UIInteraction.Click(Selectors.SaveButton);
        }
    }

    public class AddPage_Selectors
    {
        public readonly By SaveButton = By.Id("btnSave");
    }
}
