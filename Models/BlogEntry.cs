using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnleashedBlog.Models
{
    public class BlogEntry
    {
        public DateTime DatePublished { get; set; }

        public DateTime DateModified { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int id { get; set; }

        public string Text { get; set; }
    }
}