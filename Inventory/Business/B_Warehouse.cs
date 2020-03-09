using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventarioContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventarioContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }
        public void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventarioContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
