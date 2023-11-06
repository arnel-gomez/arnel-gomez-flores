namespace arnel_gomez_flores.Data.Entities
{
    public class ArticuloTienda
    {
        public int ArticuloTiendaID { get; set; }

        public int ArticuloID { get; set; }
        public Articulo Articulo { get; set; }

        public int TiendaID { get; set; }
        public Tienda Tienda { get; set; }

        public DateTime Fecha { get; set; }
    }
}
