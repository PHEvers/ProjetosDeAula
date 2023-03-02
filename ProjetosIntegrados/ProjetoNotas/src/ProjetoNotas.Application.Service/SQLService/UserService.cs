using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLService
{
    public class UserService  : IUserService
    {
        private readonly  IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<int> Save(UserDTO entity)
        {
            if(entity.id > 0)
            {
                return _userRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _userRepository.Save(entity.mapToEntity());
            }
        }
        public List<UserDTO> FindAll()
        {
            return _userRepository.FindAll()
                .Select(c => new UserDTO()
                {
                    id = c.Id,
                    login = c.Login,
                    senha = c.Senha,
                    email = c.Email,
                    name = c.Name,
                    notes = c.Notes,
                }).ToList();
        }
        public async Task<UserDTO> FindById(int id)
        {
            var dto = new UserDTO();
            return dto.mapToDTO(await _userRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _userRepository.FindById(id);
            return await _userRepository.Delete(entity);
        }
    }
}
