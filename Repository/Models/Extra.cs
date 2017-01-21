using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Extra")]
    public class Extra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public int TypeMenuItemId { get; set; }
        public virtual TypeMenuItem TypeMenuItem { get; set; }

        public virtual ICollection<ExtraSaleDetail> ExtraSaleDetails { get; set; }
    }
}
