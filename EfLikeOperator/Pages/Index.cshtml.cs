using System.Collections.Generic;
using System.Linq;
using EfLikeOperator.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EfLikeOperator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeContext _context;

        public IndexModel(EmployeeContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> EmployeesLikeTibbs = new List<Employee>();
        public IEnumerable<Employee> EmployeesContainingTibbs = new List<Employee>();

        public void OnGet()
        {            
            EmployeesContainingTibbs = _context.Employees.Where(e => e.LastName.StartsWith("Tibbs")).ToList();
            EmployeesLikeTibbs = _context.Employees.Where(e => EF.Functions.Like(e.LastName, "Tibbs%")).ToList();
        }
    }
}
