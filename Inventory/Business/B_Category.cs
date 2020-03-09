using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventarioContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventarioContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventarioContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
