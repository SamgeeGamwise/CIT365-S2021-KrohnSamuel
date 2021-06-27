using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Core_Razor.Models;

namespace MegaDesk_Core_Razor.Data
{
    public class MegaDesk_Core_RazorContext : DbContext
    {
        public MegaDesk_Core_RazorContext (DbContextOptions<MegaDesk_Core_RazorContext> options)
            : base(options)
        {
        }
        public DbSet<MegaDesk_Core_Razor.Models.DeskQuote> DeskQuote { get; set; }
    }
}
