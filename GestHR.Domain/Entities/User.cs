using GestHR.Domain.Exceptions;

namespace GestHR.Domain.Entities;

public sealed class User : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
    public DateTime DateCreated { get; set; }

    public User(string username, string email, string passwordHash, string role, DateTime dateCreated)
    {
        if (string.IsNullOrEmpty(username))
            throw new DomainExceptions("Username is required.");
        
        if (string.IsNullOrEmpty(email))
            throw new DomainExceptions("Email is required.");
        
        if (string.IsNullOrEmpty(passwordHash))
            throw new DomainExceptions("Password is required.");
        
        if (string.IsNullOrEmpty(role))
            throw new DomainExceptions("Role is required.");

        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        DateCreated = dateCreated;
    }

    public void ChangePassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            throw new DomainExceptions("Password is required.");
            
        PasswordHash = password;
    }

    public void ChangeRole(string role)
    {
        if (string.IsNullOrEmpty(role))
            throw new DomainExceptions("Role is required.");
        
        Role = role;
    }

    public void UpdateEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            throw new DomainExceptions("Email is required.");
                
        Email = email;
    }

    public void UpdateUsername(string username)
    {
        if (string.IsNullOrEmpty(username))
            throw new DomainExceptions("Username is required.");
        
        Username = username;
    }
}
