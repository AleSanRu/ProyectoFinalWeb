using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class MovimientosInventario
    {
		[Key]
		public string IdMovimiento { get; set; } = null!;
		public int? Cantidad { get; set; }
		public string? TipoMovimiento { get; set; }
		public string? Fecha { get; set; }
		public string? Descripcion { get; set; }
		public string? IdLoteFk { get; set; }

		public virtual Lote? IdLoteFkNavigation { get; set; }
	}
}
