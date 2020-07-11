using System;
using System.Collections.Generic;
using System.Text;
using ASPproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<News> News { get; set; }

    }
}
