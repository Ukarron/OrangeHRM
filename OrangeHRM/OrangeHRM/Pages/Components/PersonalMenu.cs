﻿using OpenQA.Selenium;

namespace OrangeHRM.Pages.Components
{
    public class PersonalMenu : AbstractPage<PersonalMenu_Selectors>
    {
        public PersonalMenu(AppManager p) 
            : base(p, new PersonalMenu_Selectors()) {}

        public string GetWelcomeText()
        {
            var welcomeText = app.UIInteraction.GetText(Selectors.PersonalMenuIcon);
            return welcomeText;
        }
    }

    public class PersonalMenu_Selectors
    {
        public readonly By PersonalMenuIcon = By.Id("welcome");
    }
}
