using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("ExtraSaleDetail")]
    public class ExtraSaleDetail
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public int SaleDetailId { get; set; }
        public virtual SaleDetail SaleDetail { get; set; }

        public int ExtraId { get; set; }
        public virtual Extra Extra { get; set; }
    }
}
