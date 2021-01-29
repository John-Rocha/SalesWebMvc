using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Controllers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerSevice;

        public SellersController(SellerService sellerSevice)
        {
            _sellerSevice = sellerSevice;
        }

        public IActionResult Index()
        {
            var list = _sellerSevice.FindAll();
            return View(list);
        }
    }
}
