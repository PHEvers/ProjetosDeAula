﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.Interfaces.IService
{
    public interface IBaseService<T> where T : class
    {
        Task<int> Save(T entity);
        List<T> FindAll();
        Task<T> FindById(int id);
        Task<int> Delete(int id);
    }
}
