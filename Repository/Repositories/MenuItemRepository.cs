using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class MenuItemRepository: MasterRepository<MenuItem>
    {
        public MenuItemRepository(DeliveryDataContext context) : base(context)
        {
            this.context = context;
        }

        public virtual IQueryable<MenuItem> GetByTypeMenuItemId(int typeMenuItemId)
        {
            return context.MenuItem.Where(p => p.TypeMenuItemId == typeMenuItemId);
        }

        public virtual IQueryable<MenuItem> GetByMenuId(int menuId)
        {
            return context.MenuItem.Where(p => p.MenuId == menuId);
        }
    }
}
