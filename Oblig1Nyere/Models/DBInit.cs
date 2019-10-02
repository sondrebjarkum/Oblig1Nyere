using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Oblig1Nyere.Models
{
    public class DBInit : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {

            var nyReise = new Reise
            {
                TidAvgang = new DateTime(2019, 10, 15, 8, 0, 0),
                TidAnkomst = new DateTime(2019, 10, 15, 15, 0, 0),
                Ankomst = "Oslo",
                Avgang = "Bergen"

            };
            context.Reise.Add(nyReise);

            var nyReise2 = new Reise
            {
                TidAvgang = new DateTime(2019, 10, 15, 8, 0, 0),
                TidAnkomst = new DateTime(2019, 10, 15, 15, 0, 0),
                Ankomst = "Bergen",
                Avgang = "Oslo"

            };
            context.Reise.Add(nyReise2);
          

            base.Seed(context);

            
        }
    }
}