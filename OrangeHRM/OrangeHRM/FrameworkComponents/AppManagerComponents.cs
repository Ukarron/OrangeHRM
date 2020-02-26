using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.FrameworkComponents
{
    public partial class AppManager
    {
        private IWebDriver _driver;

        private UrlManager _urlManager;
        private UIInteraction _uiInteraction;
        private Waiters _waiter;

        public AppManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public UrlManager UrlManager => _urlManager = new UrlManager(Driver);
        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(Driver);
        public Waiters Waiter => _waiter = new Waiters(Driver);       
    }
}
