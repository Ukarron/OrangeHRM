namespace OrangeHRM.Pages
{
    public abstract class AbstractPage<T>
    {
        protected AppManager app;
        private T _selectors;

        public AbstractPage(AppManager a, T type)
        {
            app = a;
            _selectors = type;
        }

        public T Selectors
        {
            get { return _selectors; }
        }
    }
}
