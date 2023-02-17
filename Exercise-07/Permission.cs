using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise_07;

[Table("Permissions")]
public class Permission
{
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Codename")]
    public string Codename { get; set; }

    public ICollection<User> Users = new List<User>();
    public ICollection<Group> Groups = new List<Group>();

    public Permission(string name, string codename)
    {
        Name = name;
        Codename = codename;
    }
}