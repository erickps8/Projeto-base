using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Template.Api.Dtos;
using Template.Business.Interfaces;
using Template.Business.Models;
using Template.Identity.Interfaces;

namespace Template.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExempleController : MainController
    {
        private readonly IExempleRepository _exempleRepository;
        private readonly IExempleService _exempleService;
        private readonly IMapper _mapper;

        public ExempleController(IExempleRepository exemplerepository, IExempleService exempleSrevice, IMapper mapper, INotificator notificator, IUser user) : base(notificator, user)
        {
            _exempleRepository = exemplerepository;
            _exempleService = exempleSrevice;
            _mapper = mapper;
        }

        [HttpGet("{id:guid}")]
        public async Task<ExempleDto> ObterPorId(Guid Id)
        {
            return _mapper.Map<ExempleDto>(await _exempleRepository.ObterPorId(Id));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<ExempleDto>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ExempleDto>>(await _exempleRepository.ObterTodos());
        }
        [HttpPost]
        public async Task<ActionResult<ExempleDto>> Adicionar(ExempleDto exempleDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _exempleService.Adicionar(_mapper.Map<Exemple>(exempleDto));

            return CustomResponse(exempleDto);
        }
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ExempleDto>> Atualizar(Guid id, ExempleDto exempleDto)
        {
            if (id != exempleDto.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na consulta");
                return CustomResponse(exempleDto);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _exempleService.Atualizar(_mapper.Map<Exemple>(exempleDto));

            return CustomResponse(exempleDto);
        }

        [HttpDelete("{id:guid}")]
        public async Task Remover(Guid id)
        {
            await _exempleRepository.Remover(id);
        }


    }
}