using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RNPN.Dominio
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        [Display(Name = "Nombre de la persona: ")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string NombrePersona { get; set; }

        [Display(Name = "Edad: ")]
        [Required(ErrorMessage = "La edad es requerida")]
        [Range(18, 120, ErrorMessage = "Solo mayores de 18 anios")]
        public int EdadPersona { get; set; }

        [Display(Name = "Descripcion: ")]
        [Required(ErrorMessage = "La descripcion es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La descripcion debe tener entre 3 y 50 caracteres")]
        public string DescripcionPersona { get; set; }
    }
}
