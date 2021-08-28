using System;
using Microsoft.EntityFrameworkCore;
namespace CMS.DB
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
