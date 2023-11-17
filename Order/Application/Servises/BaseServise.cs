using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Request;
using Application.Request.OrderItemRequest;
using Application.Response;
using AutoMapper;
using Domain.Model;

namespace Application.Servises
{
    public abstract class
        BaseService<TEntity, TBaseRequestEntity, TBaseResponseEntity> : IBaseService<TEntity, TBaseRequestEntity,
            TBaseResponseEntity>
        where TEntity : EntityBase
        where TBaseRequestEntity : BaseRequest
        where TBaseResponseEntity : BaseResponse
    {
        
         public IRepository<TEntity> _repository { get; }
        public IMapper _mapper { get; }
        public BaseService(IMapper mapper, IRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        public void Add(TBaseRequestEntity request)
        {
            var mappedEntity = _mapper.Map<TBaseRequestEntity, TEntity>(request);
            _repository.Add(mappedEntity);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TBaseResponseEntity Get(int id)
        {
            var response = _repository.FindById(id);
            return _mapper.Map<TBaseResponseEntity>(response);
        }

        public IEnumerable<TBaseResponseEntity> GetAll(int pageList, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public TBaseResponseEntity Update(int id, TBaseRequestEntity request)
        {
            throw new NotImplementedException();
        }
    }
}
