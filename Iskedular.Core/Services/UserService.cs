using Iskedular.Models;    // The User model was used
using Iskedular.Data;        // ApplicationDbContext was used (from its root Iskedular.Data namespace)
using Microsoft.EntityFrameworkCore; // EF Core methods like AddAsync, FirstOrDefaultAsync, FindAsync were used
using System.Threading.Tasks;    // Task (async/await) was used
using BCrypt.Net; // BCrypt hashing/verification functions were explicitly included

namespace Iskedular.Core.Services
{
    public class UserService
    {
        // CHANGED: Inject IDbContextFactory instead of ApplicationDbContext directly
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        // The constructor was set up for dependency injection of the DbContext Factory.
        public UserService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<User?> RegisterUserAsync(string firstName, string lastName, string email, string plainTextPassword, string programSection) // Added programSection
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                // A check was performed to see if the email already exists.
                var existingUser = await context.Users.FirstOrDefaultAsync(u => u.Email == email);
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
                    ProgramSection = programSection // Store programSection
                };

                // The password was hashed before storing (using the method in the User model).
                newUser.SetPassword(plainTextPassword);

                // The new user was added to the DbContext.
                context.Users.Add(newUser);

                // Changes were saved to the database.
                await context.SaveChangesAsync();

                return newUser; // The newly created user was returned.
            }
        }

        public async Task<User?> AuthenticateUserAsync(string email, string plainTextPassword) // Return type was updated to nullable User?
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                // The user was found by email.
                var user = await context.Users.FirstOrDefaultAsync(u => u.Email == email);

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
        }

        public async Task<User?> GetUserByIdAsync(int userId) // Return type was updated to nullable User?
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.FindAsync(userId);
            }
        }

        public async Task<bool> UpdateUserPasswordAsync(int userId, string newPlainTextPassword)
        {
            // CHANGED: Create a new DbContext instance for this operation
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = await context.Users.FindAsync(userId);
                if (user == null)
                {
                    return false; // The user was not found.
                }

                user.SetPassword(newPlainTextPassword); // The new password was hashed using the User model's method.
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
