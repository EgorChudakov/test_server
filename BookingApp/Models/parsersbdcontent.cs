using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingApp.Models
{
    public class parserDbInitializer : DropCreateDatabaseAlways<parserscontext>
    {
        protected override void Seed(parserscontext db)
        {
            db.parsers.Add(new parser { Name = "лобовое", kind = "зеркало", Year = 2019 });
            db.parsers.Add(new parser { Name = "боковое", kind = "зеркало", Year = 2020 });
            db.parsers.Add(new parser { Name = "11183", kind = "двигатель", Year = 2018 });
            
            base.Seed(db);
        }
    }
}