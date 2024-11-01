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

        public double salaryTax() {
            double rendaMensal = salaryIncome / 12;
            if (rendaMensal > 5000) {
                return salaryIncome * 0.2;
            }
            if (rendaMensal >= 3000 && rendaMensal < 5000) {
                return salaryIncome * 0.1;
            }
            return 0;
        }

        public double servicesTax() {
            if (servicesIncome > 0) {
                return servicesIncome * 0.15;
            }
            return 0;
        }

        public double capitalTax() {
            if (capitalIncome > 0) {
                return capitalIncome * 0.2;
            }
            return 0;
        }

        public double grossTax() {
            return salaryTax() + servicesTax() + capitalTax();
        }

        public double taxRebate() {
            if ((grossTax() * 0.3) > (healthSpending + educationSpending) ) {
                return healthSpending + educationSpending;
            }
            return grossTax() * 0.3;
        }

        public double netTax() {
            return grossTax() - taxRebate();
        }

    }
}
