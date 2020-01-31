namespace OrangeHRM.Pages
{
    public class AddUserPage : MainPage<AddUserPage_Selectors>
    {
        public AddUserPage(Pages p) 
            : base(p, new AddUserPage_Selectors()){}
    }

    public class AddUserPage_Selectors : MainPage_Selectors
    {

    }
}
