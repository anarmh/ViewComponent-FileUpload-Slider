﻿namespace Elearn.Models
{
    public class NewsAuthor:BaseEntity
    {
        public string FullName { get; set; }
        public ICollection<News> News { get; set; }
    }
}
