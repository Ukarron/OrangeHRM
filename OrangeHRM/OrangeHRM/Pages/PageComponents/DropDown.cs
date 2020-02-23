using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.Pages.PageComponents
{
    public class DropDown : AbstractPage<DropDown_Selectors>
    {
        private SelectElement _select;

        public DropDown(AppManager a, By option) 
            : base(a, new DropDown_Selectors())
        {
            Selectors.Option = option;
        }

        public void SelectByText(string text, bool partialMatch = false)
        {
            Select.SelectByText(text, partialMatch);
        }

        public void SelectByValue(string value)
        {
            Select.SelectByValue(value);
        }

        public void SelectByIndex(By option, int index)
        {
            Select.SelectByIndex(index);
        }

        public SelectElement Select => _select = new SelectElement(appManager.Driver.FindElement(Selectors.Option));
    }

    public class DropDown_Selectors
    {
        public By Option { get; set; }
    }
}
