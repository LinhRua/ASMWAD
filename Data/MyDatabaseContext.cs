﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASMWAD.Data
{
    public class MyDatabaseContext
    {
        public class MyDbContext : DbContext
        {
            public MyDbContext() : base("name=MyConnectionString")
            {
            }

            public System.Data.Entity.DbSet<ASMWAD.Models.Product> Products { get; set; }
        }
    }
}