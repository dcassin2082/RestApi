using RestApi.Data.Repository.Interfaces;
using RestApi.Models.Models;
using RestApi.Services.Services.Common;
using RestApi.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Services.Services.Implementation
{
    public class ContactService : ServicesBase<Contact>, IContactService
    {
        public ContactService(IRepository<Contact> repo) : base(repo)
        {
        }

        public async Task<Contact> DeleteContact(Contact contact)
        {
            return await _repo.Delete(contact);
        }

        public async Task<Contact> GetContact(int id)
        {
            return await _repo.Get(id);
        }

        public async Task<Contact> GetContact(Expression<Func<Contact, bool>> predicate)
        {
            return await _repo.Get(predicate);
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _repo.GetAll();
        }

        public async Task<List<Contact>> GetContacts(Expression<Func<Contact, bool>> predicate)
        {
            return await _repo.GetAll(predicate);
        }

        public async Task<Contact> PostContact(Contact contact)
        {
            return await _repo.Post(contact);
        }

        public async Task<Contact> PutContact(Contact contact)
        {
            return await _repo.Put(contact);
        }
    }
}
