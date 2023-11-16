using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Cuenta
    {
		[Key]
		public string IdCuenta { get; set; } = null!;
		public string? Usuario { get; set; }
		public string? Contraseña { get; set; }
		public string? IdUsuario { get; set; }

		public virtual Usuario? IdUsuarioNavigation { get; set; }
	}
}
