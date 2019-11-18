using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MayerP4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MayerP4.Data;
using Microsoft.AspNetCore.Authorization;

namespace MayerP4.Controllers
{
    [Authorize(Roles = "admin")]
    public class ResumeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        // GET: Resume
        public ActionResult Index()
        {
            var vm = new ResumeViewModel();
            vm.Intro = "My current objective is to secure a software engineering internship to gain industry experience. " +
                    "I am eager to learn from others while working on a team.";
            vm.Skills = _context.Skills.ToList();
            vm.Experiences = _context.Experiences.ToList();
            vm.Educations = _context.Educations.ToList();

            return View(vm);
        }

        [AllowAnonymous]
        // GET: Resume/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resume/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resume/Create
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

        // GET: Resume/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resume/Edit/5
        [AllowAnonymous]
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

        // GET: Resume/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resume/Delete/5
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