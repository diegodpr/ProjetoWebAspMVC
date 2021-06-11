using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ContribuintesController : Controller
    {

        private ContribuinteServices _contribuinteServices;

        public ContribuintesController (ContribuinteServices contribuinteServices)
        {
            _contribuinteServices = contribuinteServices;
        }

        public IActionResult Index()
        {
            var list = _contribuinteServices.findAll();
            return View(list);
        }
    }
}
