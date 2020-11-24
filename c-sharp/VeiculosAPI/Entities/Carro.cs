
namespace VeiculosAPI.Entities
{
    class Carro : Veiculo
    {
        public Carro(string placa)
            : base(placa)
        {
            
        }

        public Carro()
        {

        }
        
        public override int QuantidadeDePneus()
        {
            return 4;
        }
    }
}