using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VeiculosAPI2.Controllers;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MotoController motoController = new MotoController();

            motoController.Post(new Moto(){
                id = 8,
                placa = "abc128",
            });

           /* motoController.Put(2, new Moto(){
                marca = "abc",
                modelo = "2019",
                cor = "branca",     
                placa = "abc124",
                numeroQuedas = 3,
                CapotesDoGustavao = 2
            });*/



            Console.Write("teste");
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
            .UseUrls(args != null && args.Length > 0 ? args[0] : "http://0.0.0.0:5000")
            .UseStartup<Startup>();
        }
    }
}
