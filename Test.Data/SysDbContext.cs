using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Data.Entity;

namespace Test.Data
{
    public class SysDbContext:DbContext
    {
        public SysDbContext(DbContextOptions<SysDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("Server=127.0.0.1;database=sysdb;uid=root;pwd=123456;");
        }
        public DbSet<User> Users { get; set; }
    }
}
