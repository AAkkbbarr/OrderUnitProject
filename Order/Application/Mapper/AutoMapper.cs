using Application.Request.OrderRequest;
using Application.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Application.Request.OrderItemRequest;
using Application.Request.ProviderRequest;
using Domain.Model;

namespace Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<OrderRequest, OrderUnit>();
            CreateMap<OrderUnit, OrderResponse>();
            CreateMap<UpdateOrderRequest, OrderUnit>();

            CreateMap<OrderItemRequest, Domain.Model.OrderItem>();
            CreateMap<Domain.Model.OrderItem, OrderItemResponse>();
            CreateMap<UpdateProviderRequest, Domain.Model.OrderItem>();

            CreateMap<ProviderRequest, Domain.Model.Provider>();
            CreateMap<Domain.Model.Provider, ProviderResponse>();
            CreateMap<UpdateProviderRequest, Domain.Model.Provider>();
        }
    }
}
