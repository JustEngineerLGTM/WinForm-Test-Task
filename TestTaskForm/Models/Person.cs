using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskForm.Models;

[Table("persons", Schema = "dbo")]
public class Person
{
    [Key] public int Id { get; init; }

    [Column("first_name")]
    [Required, MaxLength(100)]
    public string FirstName { get; init; } = string.Empty;

    [Column("second_name")]
    [Required, MaxLength(100)]
    public string SecondName { get; init; } = string.Empty;

    [Column("last_name")]
    [Required, MaxLength(100)]
    public string LastName { get; init; } = string.Empty;

    [Column("date_employ")] public DateTime? DateEmploy { get; init; }

    [Column("date_uneploy")] public DateTime? DateUneploy { get; init; }

    [Column("status")] [Required] public int StatusId { get; init; }

    [ForeignKey(nameof(StatusId))] public Status Status { get; init; } = null!;

    [Column("id_dep")] [Required] public int DepId { get; init; }

    [ForeignKey(nameof(DepId))] public Dep Dep { get; init; } = null!;

    [Column("id_post")] [Required] public int PostId { get; init; }

    [ForeignKey(nameof(PostId))] public Post Post { get; init; } = null!;
}