﻿namespace BlogProject.Business.Dtos.Categories
{
    public class CategoryListDto
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

    }
}
