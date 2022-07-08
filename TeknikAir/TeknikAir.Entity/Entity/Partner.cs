using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikAir.Entity.Entity
{
    public class Partner
    {
        [Key]
        public int PartnerId { get; set; }
        public string? PartnerName { get; set; }
        public string? PartnerImageURL { get; set; }
    }
}
