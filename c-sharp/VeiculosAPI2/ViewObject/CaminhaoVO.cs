using Commons_Core.ViewObject;

namespace VeiculosAPI2.VO
{   
    public class CaminhaoVO : BaseVO
    {
        public string cor {get; set;}
        
        public string marca {get; set;}
        
        public string modelo {get; set;}

        public string placa {get; set;}
        
        public int numeroEixos {get; set;}
    }
}