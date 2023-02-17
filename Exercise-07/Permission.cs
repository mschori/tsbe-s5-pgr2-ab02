namespace Exercise_07;

public class Permission
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Codename { get; set; }

    public ICollection<User> Users = new List<User>();
    public ICollection<Group> Groups = new List<Group>();

    public Permission(string name, string codename)
    {
        Name = name;
        Codename = codename;
    }
}