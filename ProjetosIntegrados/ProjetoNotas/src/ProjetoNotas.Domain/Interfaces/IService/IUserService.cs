using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.Interfaces.IService
{
    public interface IUserService : IBaseService<UserDTO>
    {
    }
}
