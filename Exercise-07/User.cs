using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exercise_07;

[Table("Users")]
public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    [Column("Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Salutation")]
    public string Salutation { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Firstname")]
    public string Firstname { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(50, MinimumLength = 3)]
    [DataType(DataType.Text)]
    [Column("Lastname")]
    public string Lastname { get; set; }

    [DataType(DataType.DateTime)]
    [Column("Birthdate")]
    public DateTime Birthdate { get; set; }

    [DataType(DataType.DateTime)]
    [Column("EntryDate")]
    public DateTime EntryDate { get; set; }

    [DataType(DataType.DateTime)]
    [Column("LastLogin")]
    public DateTime LastLogin { get; set; }

    [Column("IsActive")] public bool IsActive { get; set; }

    public ICollection<Group> Groups = new List<Group>();
    public ICollection<Permission> Permissions = new List<Permission>();

    public User(string email, string firstname, string lastname)
    {
        Email = email;
        Firstname = firstname;
        Lastname = lastname;
    }
}