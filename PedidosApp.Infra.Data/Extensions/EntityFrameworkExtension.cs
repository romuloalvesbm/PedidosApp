using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PedidosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Infra.Data.Extensions
{
    /// <summary>
    /// Classe de extensão para configurar a injeção de dependência
    /// do EntityFramework e dos repositórios da infraestrutura
    /// </summary>
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFrameworkExtension(this IServiceCollection services, IConfiguration configuration)
        {
            //capturando a string de conexão do banco de dados
            var connectionString = configuration.GetConnectionString("PedidosApp");

            //fazendo a injeção de dependência da classe DataContext
            services.AddDbContext<DataContext>(
                //Configurando o tipo de banco de dados: SqlServer e passando
                //o caminho da connectionstring capturada do /appsettings
                options => options.UseSqlServer(connectionString)
                );

            return services;
        }
    }
}



