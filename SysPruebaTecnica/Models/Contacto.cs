using System.ComponentModel.DataAnnotations;
namespace SysPruebaTecnica.Models
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Mensaje { get; set; }
    }
}
