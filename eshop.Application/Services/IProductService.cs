﻿using eshop.Application.DataTransferObjects.Responses;

namespace eshop.Application.Services
{
    public interface IProductService
    {
        List<ProductCardResponse> GetProductCardResponses();
    }
}