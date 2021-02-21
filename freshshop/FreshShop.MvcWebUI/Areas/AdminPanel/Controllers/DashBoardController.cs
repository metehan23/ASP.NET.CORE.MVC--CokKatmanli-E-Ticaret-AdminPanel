using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreshShop.Model.Entity;
using FreshShop.MvcWebUI.ActionFilters;
using FreshShop.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [ActiveManagerAF]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {                    
                return View();            
        }
    }
}