using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Oblig1Nyere.Models
{
    public class Billett
    {
        public int Id { get; set; }
        public int ReiseId { get; set; }

        public virtual Reise Reise { get; set; }
    }
}