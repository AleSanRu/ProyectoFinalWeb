using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Lote
    {
		public Lote()
		{
			MovimientoInventarios = new HashSet<MovimientosInventario>();
		}
		[Key]
		public string IdLote { get; set; } = null!;
		public string? NombreLote { get; set; }
		public string? FechaElaboracion { get; set; }
		public string? FechaVencimiento { get; set; }
		public int? Cantidad { get; set; }
		public string? IdUsuario { get; set; }
		public string? IdProducto { get; set; }

		public virtual Producto? IdProductoNavigation { get; set; }
		public virtual Usuario? IdUsuarioNavigation { get; set; }
		public virtual ICollection<MovimientosInventario> MovimientoInventarios { get; set; }
	}
}
