﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventarioContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=.\\SQLExpress; Database=InventoryDb;Trusted_Connection=Yes;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId="ASP",CategoryName="Aseo Personal"},
                new CategoryEntity { CategoryId="HGR",CategoryName="Hogar"},
                new CategoryEntity { CategoryId="PRF",CategoryName="Perfumeria"},
                new CategoryEntity { CategoryId="SLD",CategoryName="Salud"},
                new CategoryEntity { CategoryId="VDJ",CategoryName="Video Juegos"}             
                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity {WarehouseId=Guid.NewGuid().ToString(), WarehouseName="Bodega Central", WarehouseAddress="Tope Central" },
                new WarehouseEntity {WarehouseId=Guid.NewGuid().ToString(), WarehouseName="Bodega Sur", WarehouseAddress="Tope SUR" },
                new WarehouseEntity {WarehouseId=Guid.NewGuid().ToString(), WarehouseName="Bodega Este", WarehouseAddress="Tope Este" }
                );
        }
    }
}
