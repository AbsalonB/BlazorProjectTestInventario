﻿using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventarioContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventarioContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventarioContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }
    }
}
