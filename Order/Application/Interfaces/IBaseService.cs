using Application.Request;
using Application.Response;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBaseService<TEntity, BaseRequestEntity, BaseResponseEntity>
        where TEntity : EntityBase
        where BaseRequestEntity : BaseRequest
        where BaseResponseEntity : BaseResponse

    {
        IEnumerable<BaseResponseEntity> GetAll(int pageList, int pageNumber);
        BaseResponseEntity Get(int id);
        void Add(BaseRequestEntity request);
        BaseResponseEntity Update(int id, BaseRequestEntity request);
        bool Delete(int id);
    }
}
