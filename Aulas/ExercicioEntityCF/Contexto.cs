using AulaEntityFramework.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEntityFramework
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Pessoas { get; set; }
        public DbSet<Curso> Emails { get; set; }
        public Contexto() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];
            string retorno = "";
            if (settings != null)
            {
                retorno = settings.ConnectionString;
            }
            optionsBuilder.UseSqlServer(retorno);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>().HasOne(e => e.pessoa).WithMany(e => e.emails).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
