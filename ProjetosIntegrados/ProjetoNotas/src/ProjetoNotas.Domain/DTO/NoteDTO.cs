using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoNotas.Domain.DTO
{
    public class NoteDTO
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public CategoryEnum category { get; set; }
        public bool _fixed { get; set; }
        public DateTime timeNote { get; set; }
        public virtual User? users { get; set; }
        public Note mapToEntity()
        {
            return new Note
            {
                Id = id,
                UserId = userId,
                Title = title,
                Description = description,
                Category= category,
                Fixed= _fixed,

            };
        }
        public NoteDTO mapToDTO(Note note)
        {
            return new NoteDTO
            {
                id = note.Id,
            };
        }
    }
}
