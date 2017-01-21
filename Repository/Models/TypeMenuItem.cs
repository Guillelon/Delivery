﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("TypeMenuItem")]
    public class TypeMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Extra> Extras { get; set; }
    }
}
