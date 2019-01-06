using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Seo { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public int Status { get; set; }
    }
}
