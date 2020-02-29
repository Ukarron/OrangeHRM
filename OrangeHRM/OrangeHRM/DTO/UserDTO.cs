using CodeBits;
using System;

namespace OrangeHRM.DTO
{
    public sealed class UserDTO
    {
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserRole UserRole { get; set; }
        public UserStatus Status { get; set; }

        public UserDTO(UserRole userRole, UserStatus status, string employeeName = null, string username = null, string password = null)
        {
            if (String.IsNullOrEmpty(employeeName))
            {
                GenerateEmployeeName();
            }
            else
            {
                EmployeeName = employeeName;
            }

            if (String.IsNullOrEmpty(username))
            {
                GenerateUsename();
            }
            else
            {
                Username = username;
            }

            if (String.IsNullOrEmpty(password))
            {
                GeneratePassword(12, PasswordCharacters.All);
            }
            else
            {
                Password = password;
            }
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
