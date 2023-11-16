using System.ComponentModel.DataAnnotations;

namespace Sinmple.Models
{
    public class Cuenta
    {
<<<<<<< HEAD
		[Key]
		public string IdCuenta { get; set; } = null!;
		public string? Usuario { get; set; }
		public string? Contraseña { get; set; }
		public string? IdUsuario { get; set; }

		public virtual Usuario? IdUsuarioNavigation { get; set; }
	}
=======
        [Key]
        public int Id_cuenta { get; set; }
        public string Usuario { get; set; }

        public string Contraseña { get; set; }
    }
>>>>>>> 7f5891263b969f04d49c94ffaf374eeea2c2c7aa
}
