using Iskedular.Models;      // The User model was used
using Iskedular.Data;        // ApplicationDbContext was used (from its root Iskedular.Data namespace)
using Microsoft.EntityFrameworkCore; // EF Core methods like AddAsync, FirstOrDefaultAsync, FindAsync were used
using System.Threading.Tasks;    // Task (async/await) was used
using BCrypt.Net; // BCrypt hashing/verification functions were explicitly included

namespace Iskedular.Core.Services
{
    // NEW: Define an interface for the UserService
    public interface IUserService
    {
        Task<User?> RegisterUserAsync(string firstName, string lastName, string email, string plainTextPassword);
        Task<User?> AuthenticateUserAsync(string email, string plainTextPassword);
        Task<User?> GetUserByIdAsync(int userId);
        Task<bool> UpdateUserPasswordAsync(int userId, string newPlainTextPassword);
        // Add any other user-related method signatures here as you create them
    }


    // The UserService class now implements the IUserService interface
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        // The constructor was set up for dependency injection of the DbContext.
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> RegisterUserAsync(string firstName, string lastName, string email, string plainTextPassword)
        {
            // A check was performed to see if the email already exists.
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (existingUser != null)
            {
                // If the email was already registered, null was returned.
                return null;
            }

            // A new User object was created.
            var newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                // PasswordHash will be set by the User model's method.
            };

            // The password was hashed before storing (using the method in the User model).
            newUser.SetPassword(plainTextPassword);

            // The new user was added to the DbContext.
            _context.Users.Add(newUser);

            // Changes were saved to the database.
            await _context.SaveChangesAsync();

            return newUser; // The newly created user was returned.
        }

        public async Task<User?> AuthenticateUserAsync(string email, string plainTextPassword)
        {
            // The user was found by email.
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                // If the user was not found, null was returned.
                return null;
            }

            // The password was verified.
            if (user.VerifyPassword(plainTextPassword))
            {
                // If the password matched, the user object was returned.
                return user;
            }
            else
            {
                // If the password was incorrect, null was returned.
                return null;
            }
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<bool> UpdateUserPasswordAsync(int userId, string newPlainTextPassword)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return false; // The user was not found.
            }

            user.SetPassword(newPlainTextPassword); // The new password was hashed using the User model's method.
            await _context.SaveChangesAsync();
            return true;
        }
    }
}