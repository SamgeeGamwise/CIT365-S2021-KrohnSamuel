using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Core_Razor.Data;
using MegaDesk_Core_Razor.Models;

namespace MegaDesk_Core_Razor.Controllers
{

    public class DeskQuoteController : Controller
    {
        private readonly MegaDesk_Core_RazorContext _context;
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
        public DeskQuoteController(MegaDesk_Core_RazorContext context)
        {
            _context = context;
        }

        // GET: DeskQuote
        public async Task<IActionResult> Index(string searchString, string sortOrder)
        {
            var quotes = from q in _context.DeskQuote
                         select q;

            if (!String.IsNullOrEmpty(searchString))
            {
                quotes = quotes.Where(q => q.LastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_asc":
                    quotes = quotes.OrderBy(q => q.LastName);
                    break;
                case "name_desc":
                    quotes = quotes.OrderByDescending(q => q.LastName);
                    break;
                case "date_asc":
                    quotes = quotes.OrderBy(q => q.QuoteDate);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(q => q.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderByDescending(q => q.QuoteDate);
                    break;
            }

            return View(await quotes.ToListAsync());
        }

        // GET: DeskQuote/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deskQuote = await _context.DeskQuote
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deskQuote == null)
            {
                return NotFound();
            }

            return View(deskQuote);
        }

        // GET: DeskQuote/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeskQuote/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Width,Depth,Drawers,Material,ShipOption,QuoteDate,CreatedDateTime")] DeskQuote deskQuote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deskQuote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deskQuote);
        }

        // GET: DeskQuote/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deskQuote = await _context.DeskQuote.FindAsync(id);
            if (deskQuote == null)
            {
                return NotFound();
            }
            return View(deskQuote);
        }

        // POST: DeskQuote/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Width,Depth,Drawers,Material,ShipOption,QuoteDate,CreatedDateTime")] DeskQuote deskQuote)
        {
            if (id != deskQuote.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deskQuote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeskQuoteExists(deskQuote.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deskQuote);
        }

        // GET: DeskQuote/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deskQuote = await _context.DeskQuote
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deskQuote == null)
            {
                return NotFound();
            }

            return View(deskQuote);
        }

        // POST: DeskQuote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deskQuote = await _context.DeskQuote.FindAsync(id);
            _context.DeskQuote.Remove(deskQuote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.Id == id);
        }
    }
}
