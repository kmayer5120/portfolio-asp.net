using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MayerP4.Data;
using MayerP4.Models;
using Microsoft.AspNetCore.Authorization;

namespace MayerP4.Controllers
{
    [Authorize(Roles = "admin")]
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacts.ToListAsync());
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // GET: Contacts/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Subject,Text")] Message contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();

                //Send email notification
                string subject = $"New message from {contact.FirstName} {contact.LastName}";
                string message = $"<p>You received a new message from {contact.FirstName} {contact.LastName} {contact.Email} on {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}:</p><p>{contact.Text}</p>";
                Services.Email.SendGmail(subject, message, new string[] { "kyle.mayer.testing.email@gmail.com" }, "kyle.mayer.testing.email@gmail.com");

                return RedirectToAction(nameof(Sent));

            }
            return View(contact);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Sent()
        {
            return View();
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var message = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }

            return View(message);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessageExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}
