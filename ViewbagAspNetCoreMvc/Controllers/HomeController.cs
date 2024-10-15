using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewbagAspNetCoreMvc.Models;

namespace ViewbagAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Details()
    {
        // String string Data
        ViewBag.Title = "Student Details Page";
        ViewBag.Header = "Student Details";

        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };

        // storing Student Data
        ViewBag.Student = student;

        return View();
    }
}
