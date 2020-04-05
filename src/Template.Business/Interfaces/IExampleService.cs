using System;
using System.Threading.Tasks;
using Template.Business.Models;

namespace Template.Business.Interfaces
{
    public interface IExampleService : IDisposable
    {
        Task<bool> Adicionar(Example exemple);
        Task<bool> Atualizar(Example exemple);
        Task<bool> Remover(Guid id);
    }
}
