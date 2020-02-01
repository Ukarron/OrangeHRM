using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRM.Pages.Components
{
    public class DropDownHandler
    {
        private IWebDriver _driver;
        private SelectElement _select;
        private By _element;

        public DropDownHandler(IWebDriver driver, By element)
        {
            _driver = driver;
            _element = element;
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

        public SelectElement Select
        {
            get
            {
                return _select = new SelectElement(_driver.FindElement(_element));
            }
        }
    }
}
