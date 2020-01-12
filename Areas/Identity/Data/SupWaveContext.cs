using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SupWave.Areas.Identity.Data;
using SupWave.Models;

namespace SupWave.Data
{
    public class SupWaveContext : IdentityDbContext<SupWaveUser>
    {
        public SupWaveContext()
        {
        }

        public SupWaveContext(DbContextOptions<SupWaveContext> options)
            : base(options)
        {
        }

        public DbSet<Playlist> Playlist { get; set; }

        public DbSet<Song> Song { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Add unique property Name on Playlist entity
            builder.Entity<Playlist>(entity =>
            {
                entity.HasIndex(e => e.Name).IsUnique();
            });
        }
    }
}
