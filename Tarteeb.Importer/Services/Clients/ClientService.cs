//=================================
// CoopyRight (c) Tarteeb LLC
// Powering True Leadership
//=================================

using Tarteeb.Importer.Brokers.Storages;
using Tarteeb.Importer.Models.Clients;
using Tarteeb.Importer.Models.Clients.Exceptions;

namespace Tarteeb.Importer.Services.Clients
{
    internal class ClientService
    {
        private readonly StorageBroker storageBroker;

        public ClientService()
        {
            storageBroker = new StorageBroker();
        }

        internal async Task<Client> AddClientAsync(Client client)
        {
            if(client is null)
                throw new NullClientException();

            return await this.storageBroker.InsertClientAsync(client);
        }
    }
}
