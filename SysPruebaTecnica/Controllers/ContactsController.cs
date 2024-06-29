using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using SysPruebaTecnica.Data;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SysPruebaTecnica.Models;

namespace SysPruebaTecnica.Controllers
{
    public class ContactsController : Controller
    {
        private readonly BDContext db;
        public ContactsController(BDContext contexto)
        {
            this.db = contexto;
        }
        // GET: ContactsController/Create
        public async Task<IActionResult> Create(int id)
        {

            var listContact = await db.Contactos.SingleOrDefaultAsync(e => e.IdContacto == id);
            ViewBag.Contactos = listContact;
            return View();
        }

        // POST: ContactsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contacto pContacto)
        {
            try
            {
                db.Contactos.Add(pContacto);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }
    }
}
