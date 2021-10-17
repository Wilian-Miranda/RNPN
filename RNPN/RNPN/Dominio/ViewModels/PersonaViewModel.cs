using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RNPN.Dominio.ViewModels
{
    public class PersonaViewModel
    {
        [Key]
        public int IdPersona { get; set; }

        [Display(Name = "Nombre de la persona: ")]
        [Required(ErrorMessage = "El nombre de la persona es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteristica")]
        public string NombrePersona { get; set; }

        [Display(Name = "Edad: ")]
        [Required(ErrorMessage = "La edad es requerida")]
        [Range(18, 120, ErrorMessage = "El registro es solo para mayores de 18 anios")]
        public int EdadPersona { get; set; }

        [Display(Name = "Descripcion: ")]
        [Required(ErrorMessage = "La descripcion es requerida")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El nombre debe tener entre 10 y 100 caracteristica")]
        public string DescripcionPersona { get; set; }
    }
}
