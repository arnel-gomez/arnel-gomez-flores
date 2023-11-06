namespace arnel_gomez_flores.Business

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using arnel_gomez_flores.Data;
    using arnel_gomez_flores.Data.Entities;

    public class TiendaService
    {
        private readonly ApplicationDbContext _context;

        public TiendaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tienda> ObtenerTodasLasTiendas()
        {
            return _context.Tiendas.ToList();
        }

        public Tienda ObtenerTiendaPorId(int tiendaId)
        {
            return _context.Tiendas.FirstOrDefault(t => t.TiendaID == tiendaId);
        }

        public void AgregarTienda(Tienda tienda)
        {
            _context.Tiendas.Add(tienda);
            _context.SaveChanges();
        }

        public void ActualizarTienda(Tienda tienda)
        {
            _context.Entry(tienda).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarTienda(int tiendaId)
        {
            var tienda = _context.Tiendas.FirstOrDefault(t => t.TiendaID == tiendaId);
            if (tienda != null)
            {
                _context.Tiendas.Remove(tienda);
                _context.SaveChanges();
            }
        }
    }
}
