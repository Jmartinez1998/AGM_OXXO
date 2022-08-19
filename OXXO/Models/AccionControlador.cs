using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OXXO.Models
{
    public partial class AccionControlador
    {
        public AccionControlador()
        {
            RolControlador = new HashSet<RolControlador>();
        }

        [Key]
        public int IdAccion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacío.")]
        public string NombreAccion { get; set; }
        public string Encabezado { get; set; }
        public int Item { get; set; }
        public int? IdControlador { get; set; }
        public bool Activo { get; set; }
        public int Usuario_FAL { get; set; }
        public int Usuario_FUM { get; set; }
        public DateTime? FUM { get; set; }
        public virtual Controlador IdControladorNavigation { get; set; }
        public virtual ICollection<RolControlador> RolControlador { get; set; }
    }
}
