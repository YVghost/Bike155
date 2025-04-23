using System.ComponentModel.DataAnnotations;

namespace Bike155.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Name { get; set; }
        public string Correo { get; set; }
        
    }
}
