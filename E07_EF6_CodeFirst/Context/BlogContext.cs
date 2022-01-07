﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace E07_EF6_CodeFirst
{
    class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=BlogContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //desativar a pluralizaçao das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       public DbSet<Blog> Blog { get; set; }
       public DbSet<Post> Post { get; set; } 
    }
}
