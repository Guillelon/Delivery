using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    [Table("Menu")]
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
