using PedidosApp.Domain.Entities;
using PedidosApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Add(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Produto? FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto entity)
        {
            throw new NotImplementedException();
        }
    }
}
