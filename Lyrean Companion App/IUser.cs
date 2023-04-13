namespace Lyrean_Companion_App
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string DisplayName { get; set; }
        bool IsDM { get; set; }
    }
}
