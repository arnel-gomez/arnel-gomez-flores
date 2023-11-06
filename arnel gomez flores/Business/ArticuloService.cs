namespace arnel_gomez_flores.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using arnel_gomez_flores.Data;
    using arnel_gomez_flores.Data.Entities;

    public class ArticuloService
    {
        private readonly ApplicationDbContext _context;

        public ArticuloService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Articulo> ObtenerTodosLosArticulos()
        {
            return _context.Articulos.ToList();
        }

        public Articulo ObtenerArticuloPorId(int articuloId)
        {
            return _context.Articulos.FirstOrDefault(a => a.ArticuloID == articuloId);
        }

        public void AgregarArticulo(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            _context.SaveChanges();
        }

        public void ActualizarArticulo(Articulo articulo)
        {
            _context.Entry(articulo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarArticulo(int articuloId)
        {
            var articulo = _context.Articulos.FirstOrDefault(a => a.ArticuloID == articuloId);
            if (articulo != null)
            {
                _context.Articulos.Remove(articulo);
                _context.SaveChanges();
            }
        }
    }
}
