
namespace Backend.Dtos
{
    public class CategoryCreated
    {

        [Required(ErrorMessage = "Name of the category must be added")]
         public string Name { get; set; } = null!;

         public string? Description { get; set; }

         public string? Emoji { get; set; }

         public DateTime? CreatedAt { get; set; }

         public DateTime? UpdatedAt { get; set; }
    }
}