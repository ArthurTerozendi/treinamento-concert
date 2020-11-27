using System.ComponentModel.DataAnnotations.Schema;

namespace VeiculosAPI2.Entities
{   
    [Table("T_CARRO")]
    public class Carro : Veiculo
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