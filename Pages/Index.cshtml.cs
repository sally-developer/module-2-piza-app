using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace PizzapartyCalculator.Pages;
public class IndexModel : PageModel
{
    [BindProperty]
    public int NumberOfGuests { get; set; }
    
    public int PizzasNeeded { get; set; }
    public double TotalCost { get; set; }
    public bool ShowResult { get; set; }
    public void OnGet()
    {
        ShowResult = false;
    }
    public void OnPost()
    {
        // Declare variables
        int slicesPerGuest = 3; // Assume each guest eats 3 slices
        int slicesPerPizza = 8; // Standard pizza has 8 slices
        double costPerPizza = 12.99;
        // Calculate the total number of slices needed
        int totalSlicesNeeded = NumberOfGuests * slicesPerGuest;
        // Calculate the number of pizzas required
        PizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);
        // Calculate total cost
        TotalCost = PizzasNeeded * costPerPizza;
        ShowResult = true;
    }
}