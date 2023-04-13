namespace Lyrean_Companion_App
{
    public interface IIdentity
    {
        // Authentification type (Forms etc..)
        string AuthenticationType { get; }
        bool IsAuthenticated { get; }
        string Name { get; }
    }
}
