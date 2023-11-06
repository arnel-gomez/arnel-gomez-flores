namespace arnel_gomez_flores.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using arnel_gomez_flores.Data;
    using arnel_gomez_flores.Data.Entities;

    public class ClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> ObtenerTodosLosClientes()
        {
            return _context.Clientes.ToList();
        }

        public Cliente ObtenerClientePorId(int clienteId)
        {
            return _context.Clientes.FirstOrDefault(c => c.ClienteID == clienteId);
        }

        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void ActualizarCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarCliente(int clienteId)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteID == clienteId);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
