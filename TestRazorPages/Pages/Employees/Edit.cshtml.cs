using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestRazorPages.Pages.Employees
{
 
    public class EditModel : PageModel
    {
        private IEmployeeRepository _employeeRepo;

        public EditModel(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Employee = _employeeRepo.GetByID(id);

            if (Employee == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Message = Employee.FirstName + " " + Employee.LastName + ", ID " + Employee.ID.ToString() + " would have been saved.";

            //return Page();
            return RedirectToPage("Index");
        }
    }
}

/*
Re: Radio Button in mvc get value
Jul 25, 2013 09:24 AM|LINK 
Give both radios the same name, but different value.
@using (Html.BeginForm())
{
  @Html.RadioButton("Gender", "male")
  @Html.RadioButton("Gender", "female")

  <input type="submit" value="Save" />
}
In your action, just take the radio name as a parameter
[HttpPost]
public ActionResult PostAction(string Gender)
{
  // do stuff with 'Gender' value
}

 */

