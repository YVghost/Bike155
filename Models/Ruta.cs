using System.ComponentModel.DataAnnotations.Schema;

namespace Bike155.Models
{
    public class Ruta
    {
        public int RutaId { get; set; }
        public string RutaDetalle { get; set; }
        public DateTime RutaDate { get; set; }
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }
    }
}
