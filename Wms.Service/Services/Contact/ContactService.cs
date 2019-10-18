using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wms.Repo;
using Wms.Service.Services.Contact;

namespace Wms.Service.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Data.Entities.Contact> _contactRepository;

        public ContactService(IRepository<Data.Entities.Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IEnumerable<Data.Entities.Contact>> Get()
        {
            return await _contactRepository.Get();
        }

        public async Task<Data.Entities.Contact> GetById(int id)
        {
            return await _contactRepository.GetById(id);
        }

        public async Task Create(Data.Entities.Contact model)
        {
           await _contactRepository.Insert(model);
        }

        public async Task Update(Data.Entities.Contact model)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Data.Entities.Contact model)
        {
            await _contactRepository.Remove(model);
        }
    }
}
