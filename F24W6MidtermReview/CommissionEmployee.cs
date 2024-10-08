﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W6MidtermReview
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        public CommissionEmployee(string name, double grossSales, double commissionRate) : base(name)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double GrossEarnings
        {
            get { return GrossSales * CommissionRate; }
        }
    }
}
