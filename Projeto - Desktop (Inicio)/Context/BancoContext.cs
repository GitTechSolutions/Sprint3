using Microsoft.EntityFrameworkCore;
using RecursosHumanos.Models;
using System;

namespace RecursosHumanos.Context
{
    public class BancoContext : DbContext

    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> FuncionarioModel { get; set; }

    }
}
