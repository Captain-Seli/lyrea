namespace Lyrean_Companion_App
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime DateJoined { get; set; }
        public bool IsDM { get; set; }

        /**
        * CreateUser(): Method to create a new user and save it to the database.
        * UpdateUser(): Method to update an existing user's information and save it to the database.
        * DeleteUser(): Method to delete a user from the database.
        * GetUserById(): Method to retrieve a user from the database by their ID.
        * GetUserByEmail(): Method to retrieve a user from the database by their email address.
        * ChangePassword(): Method to allow a user to change their password and save the new password to the database.
        * Authenticate(): Method to authenticate a user's login credentials and return a boolean indicating whether the login was successful or not.
        * GetUserRole(): Method to retrieve the role of a user (i.e. Player or DM).
        */

        // Navigation properties
        //public List<Message> Messages { get; set; }
        //public List<MonsterEncounter> MonsterEncounters { get; set; }
        //public List<InventoryItem> InventoryItems { get; set; }

        public void CreateUser()
        {
            // TODO: Implement Code to save the current user object to the database as a new record.
        }

        public void UpdateUser()
        {
            // Implement code to update the current user object in the database with the current property values.
        }

        public void DeleteUser()
        {
            // Implement code to delete the current user object from the database.
        }

        public static User GetUserById(int id)
        {
            using (var context = new LyreanCompanionDbContext())
            {
                // Retrieve the user from the database with the specified ID.
                return context.Users.FirstOrDefault(u => u.Id == id);
            }
        }

        public static User GetUserByEmail(string email)
        {
            using (var context = new LyreanCompanionDbContext())
            {
                // Retrieve the user from the database with the specified email address.
                return context.Users.FirstOrDefault(u => u.Email == email);
            }
        }

        public void ChangePassword(string newPassword)
        {
            // Update the user object's Password property with the new password.
            Password = newPassword;

            // Implement code to save the updated user object to the database.
        }

        public bool Authenticate()
        {
            using (var context = new LyreanCompanionDbContext())
            {
                // Retrieve the user from the database with the specified username and password.
                var user = context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

                // If the user exists, return true; otherwise, return false.
                return user != null;
            }
        }

        public string GetUserRole()
        {
            // Return the role of the user based on the value of the IsDM property.
            return IsDM ? "DM" : "Player";
        }
    }

  

}
}
