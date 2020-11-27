using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeiculosAPI2.Entities
{
    
    [Table("T_MOTO")]
    public class Moto : Veiculo 
    {
        public Moto(string placa)
            : base(placa)
        {
        }
        public Moto()
        {
            
        }

        [Column(name:"NUMERO_QUEDAS")]
        public int numeroQuedas {get; set;}
        
        [Column(name:"CAPOTES_DO_GUSTAVAO")]
        public int CapotesDoGustavao {get; set;}

        public override int QuantidadeDePneus()
        {
            return 2;
        }
    }
}