using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Usuario
    {
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
}
