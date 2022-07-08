using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikAir.Entity.Entity
{
    public class Reference
    {
        [Key]
        public int ReferenceId { get; set; }
        public string? ReferenceName { get; set; }
        public string? ReferenceDescription { get; set; }
        public string? ReferenceImageURL { get; set; }
        public DateTime ReferenceDate { get; set; }


    }
}
