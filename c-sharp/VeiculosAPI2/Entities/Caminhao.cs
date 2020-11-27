using System.ComponentModel.DataAnnotations.Schema;


namespace VeiculosAPI2.Entities
{   
    
    [Table("T_CAMINHAO")]
    public class Caminhao : Veiculo
    {
        public Caminhao (string placa)
            : base(placa)
        {
        }
        public Caminhao() 
        {

        }
        
        public override int QuantidadeDePneus()
        {
            return numeroEixos * 2;
        }
        
        [Column(name:"NUMERO_EIXOS")]
        public int numeroEixos {get; set;}
    }
}