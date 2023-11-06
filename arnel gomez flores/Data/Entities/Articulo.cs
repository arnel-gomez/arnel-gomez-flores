namespace arnel_gomez_flores.Data.Entities
{
    public class Articulo
    {
        public int ArticuloID { get; set; }
        public string Código { get; set; }
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public int Stock { get; set; }

        public ICollection<ClienteArticulo> ClienteArticulos { get; set; }
        public ICollection<ArticuloTienda> ArticuloTiendas { get; set; }
    }
}
