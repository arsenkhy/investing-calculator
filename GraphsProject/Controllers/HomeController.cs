using GraphsProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using IronPython.Hosting;           // Allows running python scripts
using Microsoft.Scripting.Hosting;

namespace GraphsProject.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Calculate(int years, int contribution,int starting, string period, double return_rate)
        {
            double TotalInterest = 0;
            double TotalContribution = 0;
            List<GraphModel> list = new List<GraphModel>();
            double currentYear = DateTime.Now.Year - 1;
            GraphModel model;
            double amount = starting;
            if (period == "annually")
            {
                for (double i = 1; i <= years; i++)
                {
                    TotalContribution += contribution;
                    model = new GraphModel() { StartAmount = starting };
                    model.Interest = amount * (return_rate / 100);
                    amount += contribution + model.Interest;
                    model.StartAmount = starting;
                    model.Contribution = contribution;
                    model.TotalContribution = TotalContribution;
                    TotalInterest += model.Interest;
                    model.TotalInterest = TotalInterest;

                    model.Total = model.TotalInterest + TotalContribution + starting;


                    model.Year = (int)(currentYear + 1);
                    currentYear += 1;
                    list.Add(model);
                }
            }
            //var total = (total + recentdeposit) * interestrate;
            else if (period == "monthly")
            {

                for (double i = 1; i <= years; i++)
                {
                    model = new GraphModel() { StartAmount = starting,  };
                    currentYear += 1;
                    model.Year = (int)currentYear;
                    model.StartAmount = starting;

                    for (int j = 1; j <= 12; j++) {
                        TotalContribution += contribution;
                        amount += contribution;
                        model.Contribution += contribution;
                    }
                    if (i == 1)
                    {
                        model.Interest = amount * (return_rate / 200);
                    }
                    else
                    {
                        model.Interest = amount * (return_rate / 120);

                    }
                    model.TotalContribution = TotalContribution;
                    amount += model.Interest;
                    TotalInterest += model.Interest;
                    model.TotalInterest = TotalInterest;
                    model.Total = amount;

                    list.Add(model);
                }
            }
            return Ok(list);
            //return Ok(new { list, TotalInterest, Totalearned, TotalContribution });
        }
    }
}
