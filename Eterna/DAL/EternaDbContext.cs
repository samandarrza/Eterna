﻿using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class EternaDbContext : DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options):base(options)
        {

        }

        public DbSet<Team> Teams { set; get; }
    }
}
