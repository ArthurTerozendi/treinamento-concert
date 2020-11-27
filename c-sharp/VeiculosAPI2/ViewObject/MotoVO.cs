using Commons_Core.ViewObject;

namespace VeiculosAPI2.VO
{
    public class MotoVO : BaseVO
    {
        public string cor {get; set;}
        
        public string marca {get; set;}
        
        public string modelo {get; set;}

        public string placa {get; set;}

        public int numeroQuedas {get; set;}

        public int CapotesDoGustavao {get; set;}
    }
}