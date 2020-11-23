
namespace CsharpOO_
{
    class Carro
    {   
        public string cor {get;}
        public string marca {get; set;}
        string modelo {get; set;}

        public Carro (string cor) {
            this.cor = cor;
        }
        
        public string verificaSitualcaoDetran()
        {

            return "Carro OK";
        }
    }
}