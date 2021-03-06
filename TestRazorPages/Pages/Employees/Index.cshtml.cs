using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestRazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        private IEmployeeRepository _employeeRepo;
        public List<Employee> Employees { get; set; }

        public IndexModel(IEmployeeRepository userRepo)
        {
            _employeeRepo = userRepo;
        }

        public void OnGet()
        {
            Employees = _employeeRepo.GetAll();
        }
    }
}