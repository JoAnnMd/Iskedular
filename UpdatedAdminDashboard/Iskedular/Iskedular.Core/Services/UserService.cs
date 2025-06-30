// File: Iskedular.Core.Services/UserService.cs
using Iskedular.Models;
using Iskedular.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Linq;

namespace Iskedular.Core.Services
{
    public class UserService
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public UserService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<User?> RegisterUserAsync(string firstName, string lastName, string email, string plainTextPassword)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingUser = await context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (existingUser != null)
                {
                    return null; // Email already exists
                }

                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Role = UserRole.Student,
                    DateCreated = DateTime.UtcNow
                };
                newUser.SetPassword(plainTextPassword);

                context.Users.Add(newUser);
                await context.SaveChangesAsync();
                return newUser;
            }
        }

        public async Task<User?> AuthenticateUserAsync(string email, string plainTextPassword)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.Email == email);

                if (user == null) return null;

                if (user.VerifyPassword(plainTextPassword))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.FindAsync(userId);
            }
        }

        public async Task<bool> UpdateUserPasswordAsync(int userId, string newPlainTextPassword)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = await context.Users.FindAsync(userId);
                if (user == null) return false;

                user.SetPassword(newPlainTextPassword);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.ToListAsync();
            }
        }

        public async Task<bool> UpdateUserAsync(User userToUpdate)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var existingUser = await context.Users.FindAsync(userToUpdate.Id);
                if (existingUser == null) return false;

                existingUser.FirstName = userToUpdate.FirstName;
                existingUser.LastName = userToUpdate.LastName;
                existingUser.Email = userToUpdate.Email;
                existingUser.Role = userToUpdate.Role;

                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var userToDelete = await context.Users.FindAsync(userId);
                if (userToDelete == null) return false;

                context.Users.Remove(userToDelete);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<int> GetTotalUserCountAsync()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return await context.Users.CountAsync();
            }
        }
    }
}