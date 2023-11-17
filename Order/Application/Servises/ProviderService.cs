using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Request.ProviderRequest;
using Application.Response;
using AutoMapper;

namespace Application.Servises
{
    public class ProviderService : BaseService<Domain.Model.Provider, ProviderRequest, ProviderResponse>, IProviderService
    {
        public ProviderService(IMapper mapper, IRepository<Domain.Model.Provider> repository) : base(mapper, repository)
        {
        }
    }
}
