﻿namespace Elearn.Models
{
    public class CourseImage:BaseEntity
    {
        public string Images { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
