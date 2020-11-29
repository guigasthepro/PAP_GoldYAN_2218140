using System.ComponentModel.DataAnnotations;

namespace BlazorAdmin2.Data
{
    public class CFichaCliente
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Morada { get; set; }
        public string Moradaopcional { get; set; }
        [Required]
        public string Codigopostal { get; set; }
    }
}