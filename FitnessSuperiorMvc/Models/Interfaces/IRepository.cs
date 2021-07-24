﻿using System.Collections.Generic;

namespace FitnessSuperiorMvc.BLL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        void Remove(int id);
    }
}
