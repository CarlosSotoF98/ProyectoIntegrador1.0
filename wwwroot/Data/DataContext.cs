﻿using System;

public class Class1
{
	public class DataContext : DbContext 
	{
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
	}
}
