using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models.Models;
using RestApi.Services.Services.Interfaces;
using RestApi.Web.Patterns;

namespace RestApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private int _count;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _contactService.GetContacts();
        }

        // GET: api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            var contact = await _contactService.GetContact(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // PUT: api/Contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (id != contact.ContactId)
            {
                return BadRequest();
            }

            try
            {
                await _contactService.PutContact(contact);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!(await ContactExists(id)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            await _contactService.PostContact(contact);

            return CreatedAtAction("GetContact", new { id = contact.ContactId }, contact);
        }

        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _contactService.GetContact(id);
            if (contact == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet("exists/id")]
        public async Task<bool> ContactExists(int id)
        {
            var contacts = await _contactService.GetContacts(c => c.ContactId.Equals(id));

            return contacts.Count > 0;
        }

        [HttpGet("singleton")]
        public void GetSingletonInstance()
        {
            Parallel.Invoke(
                () => GetInstance(),
                () => GetInstance()
                );
            //Singleton instance = GetInstance();

            //return instance;
        }

        private static Singleton GetInstance()
        {
            Singleton instance = null;

            instance = Singleton.Instance;
            return instance;
        }
    }
}
