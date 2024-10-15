using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewAspNetCoreMvc.Models;

namespace StronglyTypedViewAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Details()
    {
        //Using ViewBag
        ViewBag.Title = "Student Details Page";
        //Using ViewData
        ViewData["Header"] = "Student Details";
        //Creating Student Object to Hold Student data
        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };
        //Passing the Model Object as a Parameter to View Extension Method
        //It means the View is going to be a Strongly Type View for the Student Model
        return View(student);
    }
}
