using Asp.NetRazorProject.Data;
using Asp.NetRazorProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Asp.NetRazorProject.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;
       
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");

        }
      

    }
}
