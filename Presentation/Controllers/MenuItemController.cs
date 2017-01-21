using Repository.Models;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class MenuItemController : ApiController
    {
        private UnitOfWork _unitOfWork;

        public MenuItemController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IList<MenuItem> Get()
        {
            var menuItems = _unitOfWork.MenuItemRepository.GetAll().ToList();
            return menuItems;
        }

        public IList<MenuItem> GetByMenuId(int id)
        {
            var menuItems = _unitOfWork.MenuItemRepository.GetByMenuId(id).ToList();
            return menuItems;
        }

        public IList<MenuItem> GetByTypeMenuItemId(int id)
        {
            var menuItems = _unitOfWork.MenuItemRepository.GetByTypeMenuItemId(id).ToList();
            return menuItems;
        }
    }
}
