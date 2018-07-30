using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _423fund.Pages.Donate
{
    public class IndexModel : PageModel
    {
        public double Amount { get; set; }

        public void OnGet(double? amount)
        {
            Amount = amount ?? 50.00;
        }
    }
}