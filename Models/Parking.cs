using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace projeto1_curso.net.Models
{
    public class Parking
    {
        public decimal Entry { get; set; }
        public decimal CostPerHour { get; set; }
        public List<string> LicensePlate = new List<string>();

        public void cost()
        {
            Console.WriteLine("Digite o custo da entrada:");
            decimal entry = Convert.ToDecimal(Console.ReadLine());
            Entry = entry;

            Console.WriteLine("Digite o custo da hora:");
            decimal costPerHour = Convert.ToDecimal(Console.ReadLine());
            CostPerHour = costPerHour;
        }

        public void Register(string licensePlate)
        {
            LicensePlate.Add(licensePlate);
        }

        public void List()
        {
            Console.WriteLine("Carros cadastrados:");
            foreach(string item in LicensePlate)
            {
                Console.WriteLine(item);
            }
        }

        public void exit()
        {
            while (true)
            {
                Console.WriteLine("Digite a placa do seu carro:");
                string? userExit = Console.ReadLine();

                if(LicensePlate.Contains(userExit))
                {
                    Console.WriteLine("Digite quantas horas você usou o estacionamento:");
                    int hours = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Sua saída custou: R${Entry + (CostPerHour * hours)},00");
                    Console.WriteLine("Obrigado!!");

                    LicensePlate.Remove(userExit);

                    break;
                }
                else
                {
                    Console.WriteLine("Placa não encontrada");
                }
            }
        }
    }
}