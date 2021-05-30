using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Entities deki class ları veritabanı ile ilişkilendirebilmek için Context adlı bir class kurduk
    public class HotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\msssqllocaldb;Database=Hotel_DataBase;Trusted_Connection=true");
            
        }
        public DbSet<Customer> CUSTOMER_REGISTRATIONS { get; set; }
        public DbSet<Payment> PAYMENT_REGISTRATION { get; set; }
        public DbSet<Room> ROOM_INFORMATION { get; set; }
        public DbSet<User> USERS { get; set; }

    }
}
    
   
