using Microsoft.EntityFrameworkCore;
using Pizzaria.API.Domain.Models;

namespace Pizzaria.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ClientesEntity> Clientes { get; set; }
        public DbSet<EnderecosClientesEntity> EnderecoClientes { get; set; }
        public DbSet<PedidosEntity> Pedidos { get; set; }
        public DbSet<PedidosItensEntity> PedidosItens { get; set; }
        public DbSet<SaboresPizzaEntity> Sabores { get; set; }
        public DbSet<EnderecosEntregasEntity> EnderecoEntregas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ClientesEntity>().ToTable("Clientes");
            builder.Entity<ClientesEntity>().HasKey(p => p.IdCliente);

            builder.Entity<EnderecosClientesEntity>().ToTable("EnderecosClientes");
            builder.Entity<EnderecosClientesEntity>().HasKey(p => p.IdEnderecoCliente);

            builder.Entity<PedidosEntity>().ToTable("Pedidos");
            builder.Entity<PedidosEntity>().HasKey(p => p.IdPedido);

            builder.Entity<PedidosItensEntity>().ToTable("PedidosItens");
            builder.Entity<PedidosItensEntity>().HasKey(p => p.IdPedidoItem);

            builder.Entity<SaboresPizzaEntity>().ToTable("SaboresPizza");
            builder.Entity<SaboresPizzaEntity>().HasKey(p => p.IdSabor);

            builder.Entity<EnderecosEntregasEntity>().ToTable("EnderecosEntregas");
            builder.Entity<EnderecosEntregasEntity>().HasKey(p => p.IdEnderecoEntrega);


        }
    }
}
