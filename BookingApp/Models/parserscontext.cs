using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class parserscontext : DbContext
    {
        public DbSet<parser/*название класса из которого состоит БД*/> parsers/*название БД в программе*/ { get; set; }
    }
}