using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Css { get; set; }
        public string ParentId { get; set; }
        public int Status { get; set; }
        public int SortingOrder { get; set; }
    }
}
