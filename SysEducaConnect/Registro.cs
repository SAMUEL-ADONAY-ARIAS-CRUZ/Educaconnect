using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEducaConnect.EN
{
    using System.ComponentModel.DataAnnotations;

    public class Registro
    {
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Contraseña", ErrorMessage = "La contraseña y la confirmación de la contraseña no coinciden.")]
        public string ConfirmarContraseña { get; set; }
    }

}
