using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Lote
    {
<<<<<<< HEAD
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
=======
        [Key]
        public int Id_lote { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Nombre_lote no puede tener más de 50 caracteres")]
        public string Nombre_lote { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaElaboracion { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaVencimiento { get; set; }

        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Id_almacen debe ser un número entero")]
        public int Cantidad { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Cantidad debe ser un número entero")]
        public int Productos_id { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Cantidad debe ser un número entero")]
        public int Almacen_id { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "El campo Cantidad debe ser un número entero")]
        public int usuario_id { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
