using OpenQA.Selenium;

namespace OrangeHRM.Pages.Components
{
    public class PersonalMenu : AbstractPage<PersonalMenu_Selectors>
    {
        public PersonalMenu(Pages p) 
            : base(p, new PersonalMenu_Selectors()) {}

        public string GetWelcomeText()
        {
            var welcomeText = page.UIInteraction.GetText(Selectors.PersonalMenuIcon);
            return welcomeText;
        }
    }

    public class PersonalMenu_Selectors
    {
        public readonly By PersonalMenuIcon = By.Id("welcome");
    }
}
