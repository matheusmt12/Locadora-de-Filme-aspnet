using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLocadora.Models;

namespace Service
{
    public class ClienteService
    {
        private readonly AppDbContext _appDbContext;

        public int Create(Cliente cliente)
        {
            _appDbContext.Clientes.Add(cliente);
            _appDbContext.SaveChanges();
            return cliente.Id;
        }

    }
}
