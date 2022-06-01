using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Ventas.Models
{
    public class AuthRequest
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}   
