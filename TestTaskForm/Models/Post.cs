using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestTaskForm.Models;

[Table("posts", Schema = "dbo")]
public class Post
{
    [Key] public int Id { get; init; }

    [Column("name")]
    [Required, MaxLength(100)]
    public string Name { get; init; } = string.Empty;
    public ICollection<Person> Persons { get; init; } = new List<Person>();

}