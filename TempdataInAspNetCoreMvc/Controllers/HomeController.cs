using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TempdataInAspNetCoreMvc.Models;

namespace TempdataInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        TempData["Name"] = "Pranaya";
        TempData["Age"] = 30;

        //Retention of All keys of TempData for the next request
        //TempData.Keep();
        //Retention of Individual keys of TempData for the next request
        // TempData.Keep("Name");
        // TempData.Keep("Age");
        // return View();


        //We are redirecting the request to Privacy Action Method from here
        //In this case, Index View is not going to be executed
        //Means we are not reading the TempData keys and hence they available
        //in the Privacy Action method
        //return RedirectToAction("Privacy", "Home");
        return RedirectToAction("Privacy");
    }
    public ActionResult Privacy()
    {
        //Retention of Individual keys of TempData for the next request
        // TempData.Keep("Name");
        // TempData.Keep("Age");

        // return View();

        //Retention of Individual keys of TempData for the next request
        if (TempData.ContainsKey("Name"))
        {
            //Peek Method will read the data and preserve the key for next request
            ViewData["Name"] = TempData.Peek("Name");
        }
        if (TempData.ContainsKey("Age"))
        {
            //Peek Method will read the data and preserve the key for next request
            ViewData["Age"] = TempData.Peek("Age");
        }
        return View();
    }
    public ActionResult About()
    {
        //Retention of Individual keys of TempData for the next request
        //TempData.Keep("Name");
        //TempData.Keep("Age");

        return View();
    }
}
