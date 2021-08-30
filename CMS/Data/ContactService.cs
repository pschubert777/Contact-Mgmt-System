using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CMS.DB;
using System.Linq;

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
        public async Task<List<Contact>> GetContacts(string sortType ="")
        {
            

            if(sortType == "lastname")
            {
                return await _appDbContext.Contacts.OrderBy(contact => contact.LastName).ToListAsync();
            }
            else if(sortType == "firstname")
            {
                return await _appDbContext.Contacts.OrderBy(contact => contact.FirstName).ToListAsync();
            }
            else
            {
                return await _appDbContext.Contacts.ToListAsync(); 
            }


           
        }

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
