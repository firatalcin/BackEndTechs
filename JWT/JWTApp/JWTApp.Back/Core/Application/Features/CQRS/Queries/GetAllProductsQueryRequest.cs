﻿using JWTApp.Back.Core.Application.Dtos;
using MediatR;

namespace JWTApp.Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}
