using System;
using System.Threading.Tasks;
using Template.Business.Models;

namespace Template.Business.Interfaces
{
    public interface IExempleService : IDisposable
    {
        Task<bool> Adicionar(Exemple exemple);
        Task<bool> Atualizar(Exemple exemple);
        Task<bool> Remover(Guid id);
    }
}
