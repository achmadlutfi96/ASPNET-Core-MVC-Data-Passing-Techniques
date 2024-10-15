using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewdataAspNetCoreMvc.Models;

namespace ViewdataAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Details()
    {
        // String string Data
        ViewData["Title"] = "Student Details Page";
        ViewData["Header"] = "Student Details";

        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };

        // storing Student Data
        ViewData["Student"] = student;

        return View();
    }
}
