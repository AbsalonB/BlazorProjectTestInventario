using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public static class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventarioContext())
            {
                return db.Products.ToList();
            }
        } 
        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventarioContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventarioContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
        public static ProductEntity ProductByid(string id)
        {
            using (var db=new InventarioContext())
            {
                return db.Products.Where(p=>p.ProductId==id).FirstOrDefault();
            }
        }
    }
}
