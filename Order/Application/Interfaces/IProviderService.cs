using Application.Request.ProviderRequest;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProviderService : IBaseService<Domain.Model.Provider, ProviderRequest, ProviderResponse>
    {

    }
}
