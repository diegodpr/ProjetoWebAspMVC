using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;

        private readonly DepartmentsServices _departmentsServices;

        public SellersController(SellerServices sellerServices, DepartmentsServices departmentsServices)
        {
            _sellerServices = sellerServices;
            _departmentsServices = departmentsServices;
        }

        public IActionResult Index()
        {

            var list = _sellerServices.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {

            var department = _departmentsServices.FindAll();
            var viewModel = new SellerFormViewModel { Department= department};
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
