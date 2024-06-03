using Carter;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Minimal.API.Exceptions;
using Minimal.API.Requests;
using Minimal.API.Responses;

namespace Minimal.API.EndPoints
{
    public class ProductsEndpoint: ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/products");

            group.MapPost("", CreateProduct);
            group.MapGet("{id}", GetProduct).WithName(nameof(GetProduct));
            group.MapDelete("{id}", DeleteProduct);
            group.MapPut("{id}", UpdateProduct);
        }

        public async Task<Results<Ok<ProductResponse>, NotFound<string>>> GetProduct(Guid id, ISender sender)
        {
            try
            {
                var result = new ProductResponse
                {
                    Name = "Product Name",
                    Amount = 10,
                    Currency = "USD",
                    Sku = "123456"
                };

                return TypedResults.Ok(result);
            }
            catch (ProductNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        public async Task<Results<Ok<ProductResponse>, NotFound<string>>> UpdateProduct(Guid id,[FromBody] UpdateProductRequest request, ISender sender)
        {
            try
            {
                var result = new ProductResponse
                {
                    Name = "Product Name",
                    Amount = 10,
                    Currency = "USD",
                    Sku = "123456"
                };

                return TypedResults.Ok(result);
            }
            catch (ProductNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        public async Task<Results<Ok<ProductResponse>, NotFound<string>>> DeleteProduct(Guid id, ISender sender)
        {
            try
            {
                var result = new ProductResponse
                {
                    Name = "Product Name",
                    Amount = 10,
                    Currency = "USD",
                    Sku = "123456"
                };

                return TypedResults.Ok(result);
            }   
            catch (ProductNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        public async Task<Results<Ok<ProductResponse>, NotFound<string>>> CreateProduct(ProductResponse request, ISender sender)
        {
            try 
            {
                var result = new ProductResponse
                {
                    Name = "Product Name",
                    Amount = 10,
                    Currency = "USD",
                    Sku = "123456"
                };

                return TypedResults.Ok(result);
            }
            catch(ProductNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            
        }
    }
}
