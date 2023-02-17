namespace Exercise_07;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<User> Users = new List<User>();
    public ICollection<Permission> Permissions = new List<Permission>();

    public Group(string name)
    {
        Name = name;
    }
}