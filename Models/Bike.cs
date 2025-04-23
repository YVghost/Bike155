using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bike155.Models
{
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }
        public string BakeName { get; set; }
        public string BakeDescription { get; set; }
        public int RutaId { get; set; }
        [ForeignKey("RutaId")]
        public Ruta? Ruta { get; set; }
    }
}
