using System.Globalization;

namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            TaxPayer taxPayer;
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Quantos contribuintes você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i=0; i < n; i++) {
                Console.WriteLine("Digite os dados do " + (i+1) + "o Contribuinte:");
                Console.Write("Renda anual com salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Renda anual com prestação de serviço: ");
                double servicos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Renda anual com ganho de capital: ");
                double capital = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Gastos médicos: ");
                double medicoGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Gastos educacionais: ");
                double educGasto = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine();
                taxPayer = new TaxPayer(salario, servicos, capital, medicoGasto, educGasto);
                list.Add(taxPayer);
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Resumo do " + (i+1) + "o Contribuinte: ");
                Console.WriteLine("Imposto bruto total: " + list[i].grossTax().ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Abatimento: " + list[i].taxRebate().ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Imposto devido: " + list[i].netTax().ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }
        }
    }
}
