namespace Exercise_07;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Salutation { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthdate { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime LastLogin { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Group> Groups = new List<Group>();
    public ICollection<Permission> Permissions = new List<Permission>();

    public User(string email, string firstname, string lastname)
    {
        Email = email;
        Firstname = firstname;
        Lastname = lastname;
    }
}