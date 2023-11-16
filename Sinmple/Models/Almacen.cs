using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Almacen
    {
		[Key]
		public string IdAlmacen { get; set; } = null!;
		public string? Nombre { get; set; }
		public string? Ubicacion { get; set; }
	}
}
