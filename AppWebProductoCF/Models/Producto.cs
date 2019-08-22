using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebProductoCF.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        [Required (ErrorMessage = "Seleccione una categoría")]
        public int CategoriaID { get; set; }
        [StringLength (64,
            ErrorMessage = "El código no debe tener más de 64 caracteres.")]
        public string Codigo { get; set; }
        [Required (ErrorMessage = "Ingrese un nombre.")]
        [StringLength (100,MinimumLength = 3,
            ErrorMessage = "El nombre no debe tener más de 100 caracteres, ni menos de 3 caracteres.")]
        public string Nombre { get; set; }
        [Required (ErrorMessage = "Ingrese un precio de venta.")]
        public decimal Precio_Venta{ get; set; }
        [Required(ErrorMessage = "Ingrese un stock.")]
        public int Stock { get; set; }
        [StringLength(255,
            ErrorMessage = "La descripción no debe tener más de 255 caracteres.")]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
