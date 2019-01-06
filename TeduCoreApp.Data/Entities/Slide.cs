
using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Entities
{
    public class Slide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int Sort { get; set; }
        public int Status { get; set; }
        
    }
}
