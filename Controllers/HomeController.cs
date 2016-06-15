using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequence.Controllers
{
    public class HomeController : Controller
    {
      
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost]
    public ViewResult fibonacci(NumericSequence.Models.InputModel model)
    {
        if (model.Number > 1)
        {
            Int64 a = 0;
            Int64 b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (Int64 i = 0; i < model.Number; i++)
            {
                Int64 temp = a;
                a = b;
                string seriesValue = isDivRem(temp + b);
                //Assumption: as not mentioned in story whether to add value whcih is Multiple of 3 or 5 or both 
                //but displaying C,E, or Z
                b = temp + b;
                if (seriesValue == string.Empty)
                    ViewData["sequence"] = ViewData["sequence"]  + "<p>fibonacci series " + b.ToString() + "</p>";
                //Response.Write("<p>fibonacci series " + b.ToString() + "</p>");
                else
                    ViewData["sequence"] = ViewData["sequence"]  + "<p>fibonacci series " + seriesValue + " </p>";
                    //Response.Write("<p>fibonacci series " + seriesValue + " </p>");
            }
            return View("Index");
        }
        return View("Index");
    }


/// <summary>
/// Find Remainder of 3 or 5 and both.
/// </summary>
/// <param name="dividend"></param>
/// <returns>Character to Display</returns>
    private string isDivRem(long dividend)
    {
        string display = string.Empty;
        long remainderOfThree;
        long remainderOfFive;
        
        remainderOfThree = dividend % 3;
        remainderOfFive = dividend % 5;
        
        if (remainderOfThree == 0){
            display = "C";
        }

        if (remainderOfFive == 0){
            if (display != string.Empty)
                display = ",E";
            else
                display = "E";
        }

        if (display.Contains(","))
            display = "Z";
       
        return display;
    }

}
   
}
