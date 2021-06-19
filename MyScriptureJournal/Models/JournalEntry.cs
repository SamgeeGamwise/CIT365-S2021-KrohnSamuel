using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public string Note { get; set; }
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }
}
