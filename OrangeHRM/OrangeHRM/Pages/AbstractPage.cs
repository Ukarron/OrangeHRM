namespace OrangeHRM.Pages
{
    public abstract class AbstractPage<T>
    {
        protected AppManager appManager;
        private T _selectors;

        public AbstractPage(AppManager a, T type)
        {
            appManager = a;
            _selectors = type;
        }

        public T Selectors
        {
            get { return _selectors; }
        }
    }
}
