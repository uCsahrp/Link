namespace ModelsLibrary.Models
{
    public interface IUser
    {
        int Access { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string UserNAme { get; set; }
    }
}