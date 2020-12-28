using Entities;
using System;
using System.Collections.Generic;

namespace Heranca5_CSharp {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfTaxPayers; i++) {
                Console.WriteLine("\nTax payer #" + i + " data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, income, healthExpenditures));
                }
                else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, income, numberOfEmployees));
                }
            }
            double sum = 0;
            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer item in taxPayers) {
                Console.WriteLine(item);
                sum += item.Tax();
            }
            Console.Write("\nTOTAL TAXES: R$ " + sum.ToString("F2"));
        }
    }
}
