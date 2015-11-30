﻿//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;

namespace UnleashedBlog.Models
{
    public abstract class BlogRepositoryBase
    {
        //Blog Entry Methods
        public abstract List<BlogEntry> ListBlogEntries();
        public abstract void CreateBlogEntry(BlogEntry blogEntryToCreate);
        protected abstract IQueryable<BlogEntry> QueryBlogEntries();
    }
}
