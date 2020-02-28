using CodeBits;

namespace OrangeHRM.DTO
{
    public sealed class UserDTO
    {
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserRole UserRole { get; set; }
        public UserStatus Status { get; set; }

        public UserDTO(string employeeName, string username, string password, UserRole userRole, UserStatus status)
        {
            EmployeeName = employeeName;
            Username = username;
            Password = password;
            UserRole = userRole;
            Status = status;
        }

        public UserDTO(string employeeName, UserRole userRole, UserStatus status)
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
