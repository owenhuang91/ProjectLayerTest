using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectLayerTest.Models.Interface;

namespace ProjectLayerTest.Models.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        protected NorthwindEntities db
        {
            get;
            private set;
        }

        public CategoryRepository()
        {
            this.db = new NorthwindEntities();
        }

        public void Create(Categories instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Categories.Add(instance);
                this.SaveChanges();
            }
        }

        public void Delete(Categories instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Deleted;
                this.SaveChanges();
            }
        }

        public Categories Get(int categoryID)
        {
            return db.Categories.FirstOrDefault(x => x.CategoryID == categoryID);
        }

        public IQueryable<Categories> GetAll()
        {
            return db.Categories.OrderBy(x => x.CategoryID);
        }

        public void Update(Categories instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            else
            {
                db.Entry(instance).State = EntityState.Modified;
                this.SaveChanges();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}