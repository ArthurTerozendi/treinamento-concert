using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace VeiculosAPI.Entities
{
    public partial class VeiculosContext : DbContext
    {

        private IConfiguration _configuration;
        public VeiculosContext()
        {
            var builder = new ConfigurationBuilder()         
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();           
        }

        //public virtual DbSet<Carro> Carros  { get; set; }
        public virtual DbSet<Moto> Moto  { get; set; }
        public virtual DbSet<Caminhao> Caminhao  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"), o => o.SetPostgresVersion(9, 6)); 
            }
        }        
    }
}