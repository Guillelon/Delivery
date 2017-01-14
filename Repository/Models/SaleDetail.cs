using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("SaleDetail")]
    public class SaleDetail
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<ExtraSaleDetail> ExtraSaleDetails { get; set; }

        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }

        public int MenuItemId { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
