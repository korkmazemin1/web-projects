﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Efendioglu.Models

{
    public class Context : DbContext
    {
        public DbSet <Yapi> Yapis { get; set; }



    }
}