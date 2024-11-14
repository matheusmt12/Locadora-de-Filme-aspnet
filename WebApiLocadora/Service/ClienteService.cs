using Microsoft.EntityFrameworkCore;
using WebApiLocadora.DTO;
using WebApiLocadora.Models;

namespace WebApiLocadora.Service
{
    public class ClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public int Create(Cliente cliente)
        {
            cliente.Active = true;
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente.Id;
        }

        public List<ClienteDTO> GetAll(bool active)
        {
            var query = _context.Clientes.Where(c => c.Active == active)
                .Select(c => new ClienteDTO
                {
                    Name = c.Name
                });

            return query.AsNoTracking().ToList();
        }

        public ClienteDTO Get(int id)
        {
            var cliente = _context.Clientes.Select(c => new ClienteDTO
            {
                Name = c.Name
            });
            return cliente.First();
        }

        public string Delete(int id)
        {
            Cliente? cliente = _context.Clientes.Find(id);
            if (cliente != null) cliente.Active = false;
            else return "Cliente não encontrado";
            _context.Update(cliente);
            _context.SaveChanges();
            return "Cliente deletado";
        }

    }
}
