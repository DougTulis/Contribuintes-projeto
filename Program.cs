namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantos contribuintes você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++) {
                Console.WriteLine("Digite os dados do " + (i+1) + "o Contribuinte:");
                Console.Write("Renda anual com salário: ");
                double salary = double.Parse(Console.ReadLine());
                Console.Write("Renda anual com prestação de serviço: ");
                double servicos = double.Parse(Console.ReadLine());
                Console.Write("Renda anual com ganho de capital: ");
                double capital = double.Parse(Console.ReadLine());
                Console.Write("Gastos médicos: ");
                double medicoGasto = double.Parse(Console.ReadLine());
                Console.Write("Gastos educacionais: ");
                double educGasto = Double.Parse(Console.ReadLine());
            }
        }
    }
}
