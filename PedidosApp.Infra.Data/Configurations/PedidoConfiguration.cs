using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Infra.Data.Configurations
{
    /// <summary>
    /// Classe para configuração da entidade Pedido no banco de dados
    /// </summary>
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //Nome da tabela no banco de dados
            builder.ToTable("TB_PEDIDO");

            //Chave primária da tabela
            builder.HasKey(p => p.Id);

            //Mapeamento dos campos da tabela
            builder.Property(p => p.Id)
                .HasColumnName("ID"); //nome do campo

            builder.Property(p => p.Solicitante)
                .HasColumnName("SOLICITANTE") //nome do campo
                .HasMaxLength(150) //máximo de caracteres
                .IsRequired(); //not null

            builder.Property(p => p.DataHora)
                .HasColumnName("DATAHORA") //nome do campo
                .IsRequired(); //not null

            builder.Property(p => p.Detalhes)
                .HasColumnName("DETALHES") //nome do campo
                .HasMaxLength(250) //máximo de caracteres
                .IsRequired(); //not null

            builder.Property(p => p.Valor)
                .HasColumnName("VALOR") //nome do campo
                .HasColumnType("decimal(10,2)") //tipo do campo
                .IsRequired(); //not null

            builder.Property(p => p.Status)
                .HasColumnName("STATUS") //nome do campo
                .IsRequired(); //not null

            builder.Property(p => p.Ativo)
                .HasColumnName("ATIVO") //nome do campo
                .IsRequired();
        }
    }
}


