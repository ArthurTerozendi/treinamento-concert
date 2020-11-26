using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PessoasAPI.Entities
{
    public partial class PessoaContext : DbContext
    {
        private IConfiguration _configuration;
        public PessoaContext()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }

        public virtual DbSet<Pessoa> Pessoa {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"), o => o.SetPostgresVersion(9, 6)); 
            }
        }   
    }
}

