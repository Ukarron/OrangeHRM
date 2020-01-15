using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class PersonalMenu : AbstractPage<PersonalMenu_Selectors>
    {
        public PersonalMenu(Pages p) 
            : base(p, new PersonalMenu_Selectors()) {}

        public string GetWelcomeText()
        {
            var welcomeText = pages.UIInteraction.GetText(Selectors.PersonalMenuIcon);
            return welcomeText;
        }
    }

    public class PersonalMenu_Selectors
    {
        public readonly By PersonalMenuIcon = By.Id("welcome");
    }
}
