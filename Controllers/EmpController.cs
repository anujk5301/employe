using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test3April.Models;

namespace Test3April.Controllers
{
    public class EmpController : Controller
    {

        List<Emp> emp = new List<Emp>()
            {
                new Emp{Empid=1,Empname="Anuj",age=23 },
                new Emp{Empid=2,Empname="varun",age=24},
                new Emp{Empid=3,Empname="moksh",age=25}
            };
        // GET: Emp
        public ActionResult Index()
        {

            ViewBag.employee = emp;
            return View(emp);
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emp/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emp/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}