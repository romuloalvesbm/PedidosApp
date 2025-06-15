using Microsoft.EntityFrameworkCore;
using PedidosApp.Infra.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Infra.Data.Contexts
{
    /// <summary>
    /// Classe para realizar a configuração do EntityFramework
    /// para acesso a um banco de dados.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor para receber as configurações de acesso do banco de dados
        /// </summary>
        /// <param name="options">Contem os parametros de configuração</param>
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Método para adicionar as classes de configuração das entidades
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        }
    }
}
