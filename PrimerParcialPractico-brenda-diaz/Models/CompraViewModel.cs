using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using PrimerParcial.Entidades;

namespace PrimerParcialPractico_brenda_diaz.Models
{
    public class CompraViewModel
    {
        public int IdCompra { get; set; }

        [DisplayName("Proveedor")]
        [Required(ErrorMessage = "Proveedor es requerido")]
        [MaxLength(50, ErrorMessage = "El campo proveedor no puede tener más de 50 caracteres")]
        public string Proveedor { get; set; }

        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "Cantidad es requerida")]
        [Range(2, 499, ErrorMessage = "Cantidad debe ser mayor a 1 y menor a 500")]
        public int Cantidad { get; set; }

        [DisplayName("Precio U")]
        [Required(ErrorMessage = "Precio U es requerido")]
        [Range(5, 699, ErrorMessage = "Precio Unitario debe ser mayor o igual a 5 y menor a 700")]
        public int PrecioU { get; set; }

        [DisplayName("Total Venta")]
        public int TotalCompra { get; set; }

        public static Compra ToCompra(CompraViewModel ventaModel)
        {
            return new Compra
            {
                IdCompra = ventaModel.IdCompra,
                Proveedor = ventaModel.Proveedor,
                Cantidad = ventaModel.Cantidad,
                Precio = ventaModel.PrecioU
            };
        }

        public static CompraViewModel FromCompra(Compra compra)
        {
            return new CompraViewModel
            {
                IdCompra = compra.IdCompra,
                Proveedor = compra.Proveedor,
                Cantidad = compra.Cantidad,
                PrecioU = compra.Precio,
                TotalCompra = compra.TotalVenta()
            };
        }

        public static List<CompraViewModel> FromCompra(List<Compra> ventas)
        {
            return ventas
                .Select(v => FromCompra(v))
                .ToList();
        }
    }
}
