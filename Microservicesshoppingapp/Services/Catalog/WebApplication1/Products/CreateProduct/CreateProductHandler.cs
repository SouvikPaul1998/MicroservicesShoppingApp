using BuildingUtilities;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal? Price)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //Business logic to create a product
            //Create product entity from command
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            //save to database
            //return Createproduct Result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
