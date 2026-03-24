using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T, ID>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(ID id);
        List<T> FindAll();
        T? FindById(ID id);
    }
}
