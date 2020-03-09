using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventarioContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(string StorageId)
        {
            using (var db=new InventarioContext())
            {
                return db.Storages.Where(s => s.StorageId == StorageId).Any();
            }
        }
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
        public static List<StorageEntity> StorageProductByWarehouse(string ID)
        {
            using (var db=new InventarioContext())
            {
                return db.Storages
                    .Include(s=>s.Product)
                    .Include(b=>b.Warehouse)
                    .Where(s => s.WarehouseId == ID).ToList();
            }
        }
    }
}
