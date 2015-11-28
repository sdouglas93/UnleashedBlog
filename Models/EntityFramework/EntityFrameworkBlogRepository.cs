using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnleashedBlog.Models.EntityFramework
{
    public class EntityFrameworkBlogRepository: BlogRepositoryBase
    {
        private BlogDBEntities _entities = new BlogDBEntities();

        private BlogEntryEntity ConvertBlogEntryToBlogEntryEntity(BlogEntry entry) {

            var entity = new BlogEntryEntity();

            entity.id = entry.id;
            entity.Author = entry.Author;
            entity.Description = entry.Description;
            entity.Name = entry.Name;
            entity.DatePublished = entry.DatePublished;
            entity.DateModified = entry.DateModified;
            entity.Text = entry.Text;
            entity.Title = entry.Title;

            return entity;
        }

        protected override IQueryable<BlogEntry> QueryBlogEntries()
        {
          //  throw new NotImplementedException();
            return from e in _entities.BlogEntryEntities
                   select new BlogEntry
                   {
                       id = e.id,
                       Author = e.Author,
                       Description = e.Description,
                       Name = e.Name,
                       DateModified = e.DateModified,
                       DatePublished= e.DatePublished,
                       Text = e.Text,
                       Title = e.Title
                   };

        }

        public override List<BlogEntry> ListBlogEntries()
        {
            //throw new NotImplementedException();
            return QueryBlogEntries().ToList();
        }

        public override void CreateBlogEntry(BlogEntry blogEntryToCreate)
        {
            //throw new NotImplementedException();

            var entity = ConvertBlogEntryToBlogEntryEntity(blogEntryToCreate);
            _entities.AddToBlogEntryEntities(entity);
            _entities.SaveChanges();
        }
    }
}