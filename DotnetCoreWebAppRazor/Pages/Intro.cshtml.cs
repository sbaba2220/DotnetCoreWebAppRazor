using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCoreWebAppRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCoreWebAppRazor.Pages
{
    public class IntroModel : PageModel
    {
        public string Output { get; set; }
        public void OnGet()
        {
        }
        public void OnPostSubmit(NumberModel numbers)
        {
            if (numbers.FirstNumber != null && numbers.SecondNumber != null)
            {
                this.Output = string.Format("First number: {0} \n Second number: {1}", numbers.FirstNumber, numbers.SecondNumber);
            }
            else
            {
                this.Output = string.Empty;
            }
        }
    }
}
