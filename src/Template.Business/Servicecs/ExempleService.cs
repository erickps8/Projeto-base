using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Business.Interfaces;
using Template.Business.Models;
using Template.Business.Models.Validations;

namespace Template.Business.Servicecs
{
    public class ExempleService : BaseService, IExempleService
    {
        private readonly IExempleRepository _exempleRepository;
        public ExempleService(IExempleRepository exempleRepository, INotificator notificator) : base(notificator)
        {
            _exempleRepository = exempleRepository;
        }
        public async Task<bool> Adicionar(Exemple exemple)
        {
            if (!ExecutarValidacao(new ExempleValidation(), exemple)) return false;

            await _exempleRepository.Adicionar(exemple);
            return true;
        }

        public async Task<bool> Atualizar(Exemple exemple)
        {
            if (!ExecutarValidacao(new ExempleValidation(), exemple)) return false;

            await _exempleRepository.Atualizar(exemple);
            return true;
        }

        public async Task<bool> Remover(Guid id)
        {
            await _exempleRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _exempleRepository?.Dispose();
        }

    }
}
