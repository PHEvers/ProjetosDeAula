using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed
            modelBuilder.Entity<User>()
                .HasData(
                new { Id = 1, Name = "PH", Login = "PHPH", Senha = "PHPHPH", Email = "PH@PH.com"}
                );
        }

        #region DBSets<Tables>
        public DbSet<User> User { get; set; }
        public DbSet<Note> Note { get; set; }

        #endregion

    }
}
