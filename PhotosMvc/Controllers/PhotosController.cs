using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PhotosMvc.Views.Photos;
using PhotosMvc.Services;

namespace PhotosMvc.Controllers;

public class PhotosController(DataService dataService) : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View(dataService.GetAll());
    }
}
