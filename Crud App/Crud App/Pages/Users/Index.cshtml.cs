using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_App.Data;
using Crud_App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud_App.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Crud_App.Data.Crud_AppContext _context;

        public IndexModel(Crud_App.Data.Crud_AppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Emails { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }
        public async Task OnGetAsync()
        {
            var users = from u in _context.User
                         select u;
            if (!string.IsNullOrEmpty(SearchString))
            {
                users = users.Where(s => s.Name.Contains(SearchString));
            }

            User = await users.ToListAsync();
        }
    }
}
