using System.ComponentModel.DataAnnotations;
namespace AppWebLogisticaMoreno.Models.Entidades
{
    public class MOrdenCompra
    {
        [Key]
        public int idOrdenCompra { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "Debe de registrar el nombre del proveedor")]
        [MaxLength(25, ErrorMessage = "El campo no debe de tener mas de 25 caracteres")]
        public string Proveedor { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Debe de ingresar la descripcion del producto")]
        [MaxLength(35, ErrorMessage = "El campo no debe de tener mas de 35 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "UnidadMedida")]
        [Required(ErrorMessage = "Debe de ingresar la UnidadMedida")]
        [MaxLength(8, ErrorMessage = "El campo no debe de tener mas de 8 caracteres")]
        public string UnidadMedida { get; set; }

        public int Cantidad { get; set; }

        public int Precio { get; set; }

    }
}

