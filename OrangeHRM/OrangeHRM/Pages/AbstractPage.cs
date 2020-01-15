namespace OrangeHRM.Pages
{
    public abstract class AbstractPage<T>
    {
        protected Pages pages;
        protected T _selectors;

        public AbstractPage(Pages p, T type)
        {
            pages = p;
            _selectors = type;
        }

        public T Selectors
        {
            get { return _selectors; }
        }
    }
}
