using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CMS.DB;
namespace CMS.Data
{
    public class ContactService
    {
        
        // EF db connection
        private readonly AppDBContext _appDbContext;

        //constructor
        public ContactService(AppDBContext appDBContext)
        {
            _appDbContext = appDBContext;
        }


        //get all the contacts
        public async Task<List<Contact>> GetContacts() => await _appDbContext.Contacts.ToListAsync();

        public async Task AddContact(Contact contact)
        {
            await _appDbContext.Contacts.AddAsync(contact);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<Contact> GetContact(int Id)
        {
            Contact contact = await _appDbContext.Contacts.FirstOrDefaultAsync(contact => contact.Id.Equals(Id));

            return contact;
        }

        public async Task UpdateContact(Contact contact)
        {
            _appDbContext.Contacts.Update(contact);

            await _appDbContext.SaveChangesAsync();

        }

        public async Task DeleteContact(Contact contact)
        {
            _appDbContext.Remove(contact);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
