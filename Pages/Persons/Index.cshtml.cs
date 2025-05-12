using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Azure_app_rk_vs.Data;

namespace Azure_app_rk_vs.Pages_Persons
{
    public class IndexModel : PageModel
    {
        private readonly Azure_app_rk_vs.Data.AppDbContext _context;

        public IndexModel(Azure_app_rk_vs.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
