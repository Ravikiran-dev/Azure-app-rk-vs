using Azure_app_rk_vs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Azure_app_rk_vs.Pages
{
    public class DeploymentSlotsModel : PageModel
    {

        private readonly AppDbContext _context;

        public DeploymentSlotsModel(AppDbContext context)
        {
            _context = context;
        }
        public IList<Person> Person { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
