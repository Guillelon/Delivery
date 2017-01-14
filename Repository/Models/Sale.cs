using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Sale")]
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<SaleDetail> SaleDetail { get; set; }
    }
}
