﻿namespace Sozluk.EntityLayer.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}