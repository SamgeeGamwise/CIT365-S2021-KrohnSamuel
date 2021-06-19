using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string NoteSearch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookSearch { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }
        public SelectList Notes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string JournalEntryNotes { get; set; }
        public async Task OnGetAsync()
        {
            var journalEntries = from j in _context.JournalEntry
                         select j;
            if (!string.IsNullOrEmpty(NoteSearch))
            {
                journalEntries = journalEntries.Where(j => j.Note.Contains(NoteSearch));
            }

            if (!string.IsNullOrEmpty(BookSearch))
            {
                journalEntries = journalEntries.Where(j => j.Book.Contains(BookSearch));
            }

            switch (SortOrder)
            {
                case "book_asc":
                    journalEntries = journalEntries.OrderBy(s => s.Book);
                    break;
                case "book_desc":
                    journalEntries = journalEntries.OrderByDescending(s => s.Book);
                    break;
                case "date_asc":
                    journalEntries = journalEntries.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    journalEntries = journalEntries.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    journalEntries = journalEntries.OrderByDescending(s => s.DateAdded);
                    break;
            }

            JournalEntry = await journalEntries.ToListAsync();
        }

        void SortBook(MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(SortOrder))
            {

            }
        }
    }
}
