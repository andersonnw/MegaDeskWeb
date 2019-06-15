using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskWeb.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        public List<SelectListItem> shippings { get; set; }
        public List<SelectListItem> materials { get; set; }

        public CreateModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            shippings = _context.Shipping.Select(a => new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.Type

            }).ToList();

            materials = _context.Desktop.Select(a => new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.Type

            }).ToList();

            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        
        
    


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);


            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}