using OpenQA.Selenium;

namespace OrangeHRM
{
    public class PersonalMenu : AbstractPage<PersonalMenu_Selectors>
    {
        public PersonalMenu() 
            : base(new PersonalMenu_Selectors()) {}

        public string GetWelcomeText()
        {
            var welcomeText = Helpers.GetText(Selectors.PersonalMenuIcon);
            return welcomeText;
        }
    }

    public class PersonalMenu_Selectors
    {
        public readonly By PersonalMenuIcon = By.Id("welcome");
    }
}
