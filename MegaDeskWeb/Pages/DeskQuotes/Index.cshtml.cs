using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public IndexModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        //public IList<DeskQuote> DeskQuote { get;set; }
        public PaginatedList<DeskQuote> DeskQuote { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(string sortOrder,
    string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            CurrentFilter = searchString;

            IQueryable<DeskQuote> deskFilter = from d in _context.DeskQuote
                                            select d;

            if (!string.IsNullOrEmpty(SearchString))
            {
                deskFilter = deskFilter.Where(d => d.CustomerName.Contains(SearchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    deskFilter = deskFilter.OrderByDescending(d => d.CustomerName);
                    break;
                case "Date":
                    deskFilter = deskFilter.OrderBy(d => d.Date);
                    break;
                case "date_desc":
                    deskFilter = deskFilter.OrderByDescending(d => d.Date);
                    break;
                default:
                    deskFilter = deskFilter.OrderBy(d => d.CustomerName);
                    break;
            }
            int pageSize = 3;
            DeskQuote = await PaginatedList<DeskQuote>.CreateAsync(
        deskFilter.AsNoTracking(), pageIndex ?? 1, pageSize);

            //DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
