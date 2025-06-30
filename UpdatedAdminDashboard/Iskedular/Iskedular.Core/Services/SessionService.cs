using Iskedular.Models; // The User model was used

namespace Iskedular.Core.Services
{
    // This service holds the current user session information.
    // It will be registered as a Singleton in the DI container.
    public class SessionService
    {
        // The currently logged-in user. It can be null if no user is logged in.
        public User? LoggedInUser { get; private set; }

        // Sets the currently logged-in user.
        public void SetLoggedInUser(User? user)
        {
            LoggedInUser = user;
        }

        // Clears the current user session.
        public void ClearSession()
        {
            LoggedInUser = null;
        }
    }
}
