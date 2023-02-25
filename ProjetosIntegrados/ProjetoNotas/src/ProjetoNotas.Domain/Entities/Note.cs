﻿using ProjetoNotas.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public bool Fixed { get; set; }
        public DateTime TimeNote { get; set; }
        public virtual User? Users { get; set; }
    }
}
