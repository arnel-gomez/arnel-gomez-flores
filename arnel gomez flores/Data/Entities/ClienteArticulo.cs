namespace arnel_gomez_flores.Data.Entities
{
    public class ClienteArticulo
    {
        public int ClienteArticuloID { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public int ArticuloID { get; set; }
        public Articulo Articulo { get; set; }

        public DateTime Fecha { get; set; }
    }
}
