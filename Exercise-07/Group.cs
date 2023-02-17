using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise_07;

[Table("Groups")]
public class Group
{
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Name")]
    public string Name { get; set; }

    public ICollection<User> Users = new List<User>();
    public ICollection<Permission> Permissions = new List<Permission>();

    public Group(string name)
    {
        Name = name;
    }
}