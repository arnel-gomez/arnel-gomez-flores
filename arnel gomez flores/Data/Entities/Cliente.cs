namespace arnel_gomez_flores.Data.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dirección { get; set; }

        public ICollection<ClienteArticulo> ClienteArticulos { get; set; }
    }
}
