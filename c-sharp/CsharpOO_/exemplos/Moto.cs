namespace CsharpOO2
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