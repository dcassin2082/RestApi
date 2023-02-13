using RestApi.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Services.Services.Interfaces
{
    public interface IContactService
    {
        Task<List<Contact>> GetContacts();
        Task<List<Contact>> GetContacts(Expression<Func<Contact, bool>> predicate);
        Task<Contact> GetContact(int id);
        Task<Contact> GetContact(Expression<Func<Contact, bool>> predicate);
        Task<Contact> PostContact(Contact contact);
        Task<Contact> PutContact(Contact contact);
        Task<Contact> DeleteContact(Contact contact);
    }
}
