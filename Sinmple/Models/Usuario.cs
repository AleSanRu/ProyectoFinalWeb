using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Usuario
    {
<<<<<<< HEAD
		public Usuario()
		{
			Cuenta = new HashSet<Cuenta>();
			Lotes = new HashSet<Lote>();
		}
		[Key]
		public string IdUsuario { get; set; } = null!;
		public string? Nombre { get; set; }
		public string? Apellido { get; set; }
		public string? Email { get; set; }
		public string? Direccion { get; set; }
		public string? Cargo { get; set; }

		public virtual ICollection<Cuenta> Cuenta { get; set; }
		public virtual ICollection<Lote> Lotes { get; set; }
	}
=======
        [Key]
        public int Id_usuario { get; set; }

        [MaxLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "El campo Apellido no puede tener más de 50 caracteres")]
        public string Apellido { get; set; }

        [EmailAddress(ErrorMessage = "El campo Correo debe ser una dirección de correo electrónico válida")]
        public string Correo { get; set; }

        [MaxLength(100, ErrorMessage = "El campo Direccion no puede tener más de 100 caracteres")]
        public string Direccion { get; set; }

        public string Roles { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
