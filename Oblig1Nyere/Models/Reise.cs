using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Oblig1Nyere.Models
{
    public class Reise
    {
        public int Id { get; set; }
        public DateTime TidAvgang { get; set; }
        public DateTime TidAnkomst { get; set; }
        public string Ankomst { get; set; }
        public string Avgang { get; set; }
        public virtual List<Billett> Billetter { get; set; }
    }
}