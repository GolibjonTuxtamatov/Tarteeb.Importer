//=================================
// CoopyRight (c) Tarteeb LLC
// Powering True Leadership
//=================================


using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Tarteeb.Importer.Models.Clients;

namespace Tarteeb.Importer.Brokers.Storages
{
    internal class StorageBroker : EFxceptionsContext
    {
        public StorageBroker() =>
           this.Database.EnsureCreated();

        public DbSet<Client> Clients { get; set; }

        public async Task<Client> InsertClientAsync(Client client)
        {
            await this.Clients.AddAsync(client);
            await this.SaveChangesAsync();

            return client;
        }

        public IQueryable<Client> SelectAllClients() =>
            this.Clients.AsQueryable();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = ../../../Tarteeb.db";
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
