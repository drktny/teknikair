﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikAir.Entity.Entity
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string? AboutDescription { get; set; }
    }
}
