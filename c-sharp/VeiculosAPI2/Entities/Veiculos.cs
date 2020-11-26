using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Commons_Core.Entities;

namespace VeiculosAPI2.Entities
{
    public abstract class Veiculo : BaseEntity
    {
        public Veiculo (string placa)
        {
            this.placa = placa;
        }
        public Veiculo () 
        {

        }
        [Key]
        [Required]
        public long id {get; set;}

        [Column(name:"COR")]
        public string cor {get; set;}
        
        [Column(name:"MARCA")]
        public string marca {get; set;}
        
        [Column(name:"MODELO")]
        public string modelo {get; set;}

        [Column(name:"PLACA")]
        private string _placa;

        public string placa 
        {
            get
            {
                return _placa;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _placa = value.ToUpper().Replace("-", "").Replace("_", "");
                }
            }
        }

        public override string ToString()
        {
            return "Placa: " + this.placa
                + " Cor: " + this.cor
                + " Modelo: " + this.modelo
                + " Marca: " + this.marca;
        }

        public string ToString(bool imprimePlaca) 
        {
            if(imprimePlaca)
            {
                return "Placa: " + this.placa;
            }
            return ToString();
        }

        public abstract int QuantidadeDePneus();
    }
}