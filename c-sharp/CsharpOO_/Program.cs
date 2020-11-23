using System;

namespace CsharpOO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro("prata");
            car.marca = "prata";
            Console.WriteLine("Situação do carro: " + car.verificaSitualcaoDetran() + " " + car.cor);
        }
    }
}
