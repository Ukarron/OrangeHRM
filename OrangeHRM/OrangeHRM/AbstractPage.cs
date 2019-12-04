﻿using OpenQA.Selenium;
using OrangeHRMTests;

namespace OrangeHRM
{
    public abstract class AbstractPage<T>
    {
        private IWebDriver _driver;
        private Helpers _helpers;
        private T _selectors;

        public AbstractPage(T type)
        {
            _driver = Browser.Driver;
            _selectors = type;
        }

        public T Selectors
        {
            get
            {
                return _selectors;
            }
        }

        public Helpers Helpers
        {
            get
            {
                _helpers = new Helpers(_driver);
                return _helpers;
            }
        }
    }

    public abstract class AbstractPage_Selectors
    {
        /*public abstract class APage<T>
    {
        protected Pages page;
        protected T selectors;
        public T Selectors 
        { 
            get {return selectors;} 
        }

        protected APage(Pages p, T t) 
        { 
            page = p;
            selectors = t;
        }
    }*/
    }
}
