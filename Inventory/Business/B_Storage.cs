using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventarioContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventarioContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
