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

        // Navigation properties
        //public List<Message> Messages { get; set; }
        //public List<MonsterEncounter> MonsterEncounters { get; set; }
        //public List<InventoryItem> InventoryItems { get; set; }

        public void CreateUser()
        {

        }

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

    }
}
