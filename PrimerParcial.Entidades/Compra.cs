namespace PrimerParcial.Entidades
{
    public class Compra
    {
        public int IdCompra {  get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
         public int Precio { get; set; }
        public int TotalVenta()
        {
            return Cantidad * Precio;
        }
    }
}
