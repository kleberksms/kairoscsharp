using System;
using System.Collections.Generic;
using Kairos.Application.Interfaces;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class BaseApplicationService<TEntity> : IDisposable, IBaseApplicationService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;

        public BaseApplicationService(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public void Add(TEntity obj)
        {
            _baseService.Add(obj);

        }

        public TEntity GetById(int id)
        {
            return _baseService.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _baseService.GetAll();
        }

        public void Update(TEntity obj)
        {
            _baseService.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _baseService.Remove(obj);
        }

        public void Dispose()
        {
            _baseService.Dispose();
        }
    }
}
