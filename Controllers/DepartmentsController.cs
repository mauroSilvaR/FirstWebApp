using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SalesApp.Models;
namespace SalesApp.Controllers{
public class DepartmentsController : Controller
{

        public IActionResult Index()
    {
        List<Department>lista= new List<Department>();
        lista.Add(new Department{Id=1,Name="Electronics"});
        lista.Add(new Department{Id=2,Name="Fashion"});
        return View(lista);
    }

}

}