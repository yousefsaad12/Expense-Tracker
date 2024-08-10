using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
    }
}