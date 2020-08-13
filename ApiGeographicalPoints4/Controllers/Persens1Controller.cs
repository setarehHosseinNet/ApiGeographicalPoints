using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting.DataLayer2.Models;
using Accounting.Business2;

namespace ApiGeographicalPoints4.Controllers
{
    [Route("/[controller]")]
    public class Persens1Controller : Controller
    {
        private  Account _context =new Account();

     

        // GET: Persens1
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetPersen());
        }

        // GET: Persens1/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persen = await _context.Persen
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (persen == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(persen);
        //}

        // GET: Persens1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Persens1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Password")] Persen persen)
        {
            if (ModelState.IsValid)
            {
                await _context.PostPersen(persen);
               
                return RedirectToAction(nameof(Index));
            }
            return View(persen);
        }

        // GET: Persens1/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persen = await _context.Persen.FindAsync(id);
        //    if (persen == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(persen);
        //}

        //// POST: Persens1/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Password")] Persen persen)
        //{
        //    if (id != persen.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(persen);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PersenExists(persen.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(persen);
        //}

        //// GET: Persens1/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var persen = await _context.Persen
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (persen == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(persen);
        //}

        //// POST: Persens1/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var persen = await _context.Persen.FindAsync(id);
        //    _context.Persen.Remove(persen);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PersenExists(int id)
        //{
        //    return _context.Persen.Any(e => e.ID == id);
        //}
    }
}
