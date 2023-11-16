using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Producto
    {
		public Producto()
		{
			Lotes = new HashSet<Lote>();
		}
		[Key]
		public string IdProducto { get; set; } = null!;
		public string? Nombre { get; set; }
		public string? Tipo { get; set; }

		public virtual ICollection<Lote> Lotes { get; set; }
	}
}
