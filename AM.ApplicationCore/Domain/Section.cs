﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Section
    {
        [Key]
        public int IdSection { get; set; }
        [Required(ErrorMessage = "PLZ ENTER NAME"), MinLength(1)]
        public string Name { get; set; }
        public virtual IList<Seat> Seats { get; set;}
    }
}
