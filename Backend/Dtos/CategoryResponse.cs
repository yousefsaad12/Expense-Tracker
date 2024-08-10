
namespace Backend.Dtos
{
    public class CategoryResponse
    {
         public string Name { get; set; } = null!;

         public string? Description { get; set; }

         public string? Emoji { get; set; }

         public DateTime? CreatedAt { get; set; }

         public DateTime? UpdatedAt { get; set; }
    }
}