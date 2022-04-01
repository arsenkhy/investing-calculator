using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphsProject.Models
{
    public class GraphModel
    {
        public int Year { get; set; }
        public double Rate { get; set; }
        public double Contribution { get; set; }
        public string Period { get; set; }
        public int StartAmount { get; set; }
        public double Interest { get; set; }
        public double Total { get; set; }
        public double TotalContribution { get; set; }
        public double TotalInterest { get; set; }
    }
}
