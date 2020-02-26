using CodeBits;

namespace OrangeHRM.Models
{
    public sealed class UserModel
    {
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserRole UserRole { get; set; }
        public UserStatus Status { get; set; }

        public UserModel(string employeeName, string username, string password, UserRole userRole, UserStatus status)
        {
            EmployeeName = employeeName;
            Username = username;
            Password = password;
            UserRole = userRole;
            Status = status;
        }

        public UserModel(string employeeName, UserRole userRole, UserStatus status)
        {
            EmployeeName = employeeName;
            Username = GenerateUsename();
            Password = GeneratePassword(12, PasswordCharacters.All);
            UserRole = userRole;
            Status = status;
        }

        public string GenerateEmployeeName()
        {
            return EmployeeName = Faker.Name.FullName();
        }

        public string GenerateUsename()
        {
            return Username = Faker.Internet.UserName();
        }

        public string GeneratePassword(int length, PasswordCharacters allowedCharacters)
        {
            return Password = PasswordGenerator.Generate(length, allowedCharacters);
        }
    }

    public enum UserRole
    {
        Admin,
        ESS
    }

    public enum UserStatus
    {
        Enabled,
        Disabled
    }
}
