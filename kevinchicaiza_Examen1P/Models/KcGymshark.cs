using System.ComponentModel.DataAnnotations;
using System.Data;

namespace kevinchicaiza_Examen1P.Models
{
    public class KcGymshark
    {
        [Key]
        public int KCRopaid { get; set; }

        [Required]
        [StringLength(50)]
        public string? KCName { get; set; }
        public bool KCtallas { get; set; }
        [Range(0.01, 99.99)]
        
        public decimal KCPrecio { get; set; }


        [EmailAddress]
        public string? Emaildelusuario { get; set; }
        public DateTime KCFechadeEntrada { get; set; }

        public DateTime KCFechadeSalida { get; set; }

        public string KCColor { get; set; }

        public string KCGenero { get; set; }  // Género (masculino, femenino, unisex)
        public string  KcTipoderopa { get; set; }  // Tipo de prenda (camiseta, pantalón, etc.)
        public string? KCDescripcion { get; set; }

    }
}
