﻿using Elearn.Models;

namespace Elearn.Areas.Admin.ViewModels.Course
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CourseAuthorId { get; set; }
        public CourseAuthor CourseAuthor { get; set; }
        public ICollection<CourseImage> CourseImages { get; set; }
    }
}

