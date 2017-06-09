using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AzureWebApi2FromScratch.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection") {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
    }
}