using System;
using Dotnet5.GraphQL.WebApplication.Domain.Entities;
using Dotnet5.GraphQL.WebApplication.Domain.Entities.Products;
using Dotnet5.GraphQL.WebApplication.Services;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace Dotnet5.GraphQL.WebApplication.MVC.GraphQL.Types
{
    public sealed class ProductGraphType : ObjectGraphType<Product>
    {
        public ProductGraphType(IReviewService reviewService, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Field(x => x.Id, type: typeof(GuidGraphType));
            Field(x => x.Description);
            Field(x => x.IntroduceAt);
            Field(x => x.Name).Description("The name of the product.");
            Field(x => x.PhotoFileName);
            Field(x => x.Price);
            Field(x => x.ProductType, type: typeof(ProductTypeGraphType));
            Field(x => x.Rating);
            Field(x => x.Stock);
            Field<ProductOptionEnumGraphType>("Option");

            FieldAsync<ListGraphType<ReviewGraphType>>("reviews",
                resolve: async context
                    => await dataLoaderContextAccessor.Context
                       .GetOrAddCollectionBatchLoader<Guid, Review>("GetReviewsByProductId", reviewService.GetForProductsAsync)
                       .LoadAsync(context.Source.Id));
        }
    }
}