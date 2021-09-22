using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private static List<MenuItem> menuItemList = new List<MenuItem>()
        {
            new MenuItem(){
                Id=1,
                Name="Buttor Chicken",
                FreeDelivery=false,
                DateOfLaunch= DateTime.Today.Date,
                Price=200.0,
                Active = true
            },
            new MenuItem(){
                Id=2,
                Name="Buttor Paneer Masala",
                FreeDelivery=false,
                DateOfLaunch= DateTime.Today.Date,
                Price=180.0,
                Active = true
            },
            new MenuItem(){
                Id=3,
                Name="Roti",
                FreeDelivery=true,
                DateOfLaunch= DateTime.Today.Date,
                Price=10.0,
                Active = true
            }
        };
        
        [HttpGet]
        [Route("menu")]
        public IEnumerable<MenuItem> getMenu()
        {
            return menuItemList.ToArray();
        }

        [HttpGet]
        [Route("menu/{id}")]
        public MenuItem getMenuById(int id)
        {
            return menuItemList.FirstOrDefault(x => x.Id == id);
        }
    }
}
