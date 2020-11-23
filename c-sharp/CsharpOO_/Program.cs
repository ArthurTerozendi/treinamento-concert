using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsharpOO2;

namespace CsharpOO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro("prata");
            //Veiculo veiculo = new Veiculo();
            Console.WriteLine("Situação do carro: " + car.verificaSitualcaoDetran());
            List<Carro> veiculos = importarVeiculos<Carro>("C:/Users/Arthur/Documents/MeusProjetosGit/treinamento-concert/c-sharp/CsharpOO_/csv/veiculos.csv");
            foreach (var veiculo in veiculos) 
            {
                Console.WriteLine(veiculo.ToString());
            }
        }

        public static List<T> importarVeiculos<T>(string CSVPath)
        where T : Veiculo, new()
        {
            var todasAsLinhas = File.ReadAllLines(CSVPath);
            var veiculos = todasAsLinhas.Select(m => {
                var infCar = m.Split(";");
                var car = new T();
                car.placa =infCar[0];
                car.cor = infCar[1];
                car.marca = infCar[2];
                car.modelo = infCar[3];
             
                return car;
            }).ToList<T>();
            return veiculos;
        }
    }
}
