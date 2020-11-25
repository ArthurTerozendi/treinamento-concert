namespace VeiculosAPI2.Entities
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

        public int numeroQuedas {get; set;}
        public int CapotesDoGustavao {get; set;}

        public override int QuantidadeDePneus()
        {
            return 2;
        }
    }
}