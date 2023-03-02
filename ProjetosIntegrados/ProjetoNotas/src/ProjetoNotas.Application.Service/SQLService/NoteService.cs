using ProjetoNotas.Application.Service.SQLService;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using ProjetoNotas.Infra.Data.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLService
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _noteRepository.FindById(id);
            return await _noteRepository.Delete(entity);
        }
        public List<NoteDTO> FindAll()
        {
            return _noteRepository.FindAll()
        .Select(c => new NoteDTO()
        {
            id = c.Id,
            userId = c.UserId,
            title = c.Title,
            description = c.Description,
            category = c.Category,
            _fixed = c.Fixed,
            timeNote = c.TimeNote,
            users = c.Users

        }).ToList();
        }
        public async Task<NoteDTO> FindById(int id)
        {
            var dto = new NoteDTO();
            return dto.mapToDTO(await _noteRepository.FindById(id));
        }
        public Task<int> Save(NoteDTO entity)
        {
            if (entity.id > 0)
            {
                return _noteRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _noteRepository.Save(entity.mapToEntity());
            }
        }
    }
}
