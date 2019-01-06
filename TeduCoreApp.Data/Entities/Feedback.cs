using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Entities
{
    public class Feedback
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
    }
}
