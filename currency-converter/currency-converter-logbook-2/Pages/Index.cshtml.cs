using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace currency_converter_logbook_2.Pages
{
    public class IndexModel : PageModel
    {
        public double? euros;

        public void OnGet()
        {
            euros = null;
        }

        public double CalculateOutput(double amount)
        {
            return amount * 1.14;
        }

        public void OnPost()
        {
            if (string.IsNullOrEmpty(Request.Form["euros"])) return; // If there is no input value, return
            this.euros = Math.Round(CalculateOutput(double.Parse(Request.Form["euros"])), 2); // Specifies the euro variable, applies the calculate output function, and rounds it to two decimal places.
        }
    }
}