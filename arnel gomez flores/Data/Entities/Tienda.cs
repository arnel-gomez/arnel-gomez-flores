namespace arnel_gomez_flores.Data.Entities
{
    public class Tienda
    {
        public int TiendaID { get; set; }
        public string Sucursal { get; set; }
        public string Dirección { get; set; }

        public ICollection<ArticuloTienda> ArticuloTiendas { get; set; }
    }
}
