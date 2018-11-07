﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace T1708M1New.Models
{
    public class T1708M1NewContext : DbContext
    {
        public T1708M1NewContext (DbContextOptions<T1708M1NewContext> options)
            : base(options)
        {
        }

        public DbSet<T1708M1New.Models.Student> Student { get; set; }
    }
}
