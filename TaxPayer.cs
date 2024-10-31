using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    internal class TaxPayer {
        public double salaryIncome { get; set; }
        public double servicesIncome { get; set; }
        public double capitalIncome { get; set; }
        public double healthSpending { get; set; }
        public double educationSpending { get; set; }

        public TaxPayer(double salaryIncome, double servicesIncome, double capitalIncome, double healthSpending, double educationSpending) {
            this.salaryIncome = salaryIncome;
            this.servicesIncome = servicesIncome;
            this.capitalIncome = capitalIncome;
            this.healthSpending = healthSpending;
            this.educationSpending = educationSpending;
        }

    }
}
