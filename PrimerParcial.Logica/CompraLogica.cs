using PrimerParcial.Entidades;

namespace PrimerParcial.Logica
{
    public class CompraLogica : ICompraLogica
    {
        private List<Compra> _items = new List<Compra>();

        public void RegistrarCompra(Compra compra)
        {
            compra.IdCompra = _items.Count == 0 ? 1 : _items.Max(x => x.IdCompra) + 1;
            _items.Add(compra);
        }


        public List<Compra> Resultados()
        {
            return _items
                .OrderBy(x => x.IdCompra)
                .ToList();
        }
    }

    public interface ICompraLogica
    {
        void RegistrarCompra(Compra compra);
        List<Compra> Resultados();
    }
}