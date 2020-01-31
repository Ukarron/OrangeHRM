using Allure.Commons;

namespace OrangeHRM.Pages
{
    public abstract class AbstractPage<T>
    {
        protected Pages page;
        private T _selectors;

        public AbstractPage(Pages p, T type)
        {
            page = p;
            _selectors = type;
        }

        public T Selectors
        {
            get { return _selectors; }
        }
    }
}
