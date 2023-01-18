using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;
using SchoolManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext _Context;

        public StudentController(DataContext dataContext)
        {
            _Context = dataContext;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View("Views/Student/Create.cshtml");
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create( [Bind("StudentId,Name,SurName,ClasseId,Age,gender,DateOfBirth,ResponsableLegal,Profession,Adresse,Ville,TelePhone,Email,AcademicYear")] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Context.Add(student);
                    await _Context.SaveChangesAsync();
                    return RedirectToAction(nameof(Create));
                }
                return View("Views/Student/Create.cshtml");
            }
            catch
            {
                return View("Views/Student/Create.cshtml");
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
