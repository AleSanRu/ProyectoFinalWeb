using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Producto
    {
<<<<<<< HEAD
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
=======
        [Key]
        public int Productos_id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "El campo tipo no puede tener más de 50 caracteres")]
        public string tipo { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
