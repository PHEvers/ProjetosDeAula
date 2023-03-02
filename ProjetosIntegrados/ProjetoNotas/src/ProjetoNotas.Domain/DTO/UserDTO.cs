using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.DTO
{
    public class UserDTO
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public virtual ICollection<Note>? notes { get; set; }
        public User mapToEntity()
        {
            return new User
            {
                Id = id,
                Login = login,
                Senha = senha,
                Email = email,
                Name = name,
                Notes = notes
            };
        }
        public UserDTO mapToDTO(User user)
        {
            return new UserDTO
            {
                id = user.Id,
                login = user.Login,
                senha = user.Senha,
                email = user.Email,
                name = user.Name,
                notes = user.Notes
            };
        }
    }
}
