using System.ComponentModel.DataAnnotations;

namespace ProyectoDSP.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El campo Id es obligatorio")]
        public string Id { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "El campo Username es obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo APELLIDO PATERNO es obligatorio")]
        public string Paterno { get; set; }
        [Required(ErrorMessage = "El campo APELLIDO MATERNO es obligatorio")]
        public string Materno { get; set; }
        [Required(ErrorMessage = "El campo Edad es obligatorio")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        public string Direccion { get; set; }
    }
}
