using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class MovimientosInventario
    {
<<<<<<< HEAD
		[Key]
		public string IdMovimiento { get; set; } = null!;
		public int? Cantidad { get; set; }
		public string? TipoMovimiento { get; set; }
		public string? Fecha { get; set; }
		public string? Descripcion { get; set; }
		public string? IdLoteFk { get; set; }

		public virtual Lote? IdLoteFkNavigation { get; set; }
	}
=======
        [Key]
        public int Id_movimiento { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Cantidad debe ser un número entero")]
        public int Cantidad { get; set; }

        public string TipoMovimiento { get; set; }

        public DateTime Fecha { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Cantidad debe ser un número entero")]
        public int id_lote { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
