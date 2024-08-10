namespace Backend.Mappers
{
    public static class CategoryMapper
    {
        public static Category ToCategory(this CategoryCreated categoryCreated)
        {
            return new Category
            {
                Name = categoryCreated.Name,
                Description = categoryCreated.Description,
                Emoji = categoryCreated.Emoji,
                CreatedAt = categoryCreated.CreatedAt,
                UpdatedAt = categoryCreated.UpdatedAt,
            };
        }

        public static CategoryResponse ToCategoryResponse (this Category category)
        {
            return new CategoryResponse
            {
                Name = category.Name,
                Description = category.Description,
                Emoji = category.Emoji,
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdatedAt,
            };
        }
    }
}