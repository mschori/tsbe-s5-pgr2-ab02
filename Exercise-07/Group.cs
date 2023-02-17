using System.ComponentModel.DataAnnotations;

namespace Exercise_07;

public class Group
{
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(350, MinimumLength = 300)]
    [DataType(DataType.Text)]
    public string Name { get; set; }

    public ICollection<User> Users = new List<User>();
    public ICollection<Permission> Permissions = new List<Permission>();

    public Group(string name)
    {
        Name = name;
    }
}