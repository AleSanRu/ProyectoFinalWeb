using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Almacen
    {
<<<<<<< HEAD
		[Key]
		public string IdAlmacen { get; set; } = null!;
		public string? Nombre { get; set; }
		public string? Ubicacion { get; set; }
	}
=======
        [Key]
        public int Id_almacen { get; set; }
        [MaxLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(100, ErrorMessage = "El campo Ubicacion no puede tener más de 100 caracteres")]
        public string Ubicacion { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
