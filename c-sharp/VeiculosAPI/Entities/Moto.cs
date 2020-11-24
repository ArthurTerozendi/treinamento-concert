namespace VeiculosAPI.Entities
{
    public class Moto : Veiculo 
    {
        public Moto(string placa)
            : base(placa)
        {
        }
        public Moto()
        {
            
        }

        public override int QuantidadeDePneus()
        {
            return 2;
        }
    }
}