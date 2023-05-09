# Mediator

## More details about the architecture .

* 1 - Application Folder
    * Application Layer 
    * In This Layer , Have Command And Queries And Handlers .
* 2 - Service Folder
    * Service Layer 
    * For Data Persistence And Use ORM (Entity FrameWork). 

### first You need to install the following packages :
```cm
NuGet\Install-Package Mediator.SourceGenerator 

NuGet\Install-Package Mediator.Abstractions 
```
### You only need to set two fields of its options, time to add MediatorServices on project in Startup.cs file 
### Set "Namespace" and Set "ServiceLifetime"

```csharp
services.AddMediator(options =>
{
    options.Namespace = "WebApplicationMediator";
    options.ServiceLifetime = ServiceLifetime.Transient;
});
```

### the Final level for use "Mediator" : 
* Go To Application Folder (Layer) And Create Command Or Query and Use down Code in Application Layer .
* You Should Use "ICommand" for Command
* Use "IQuery" for Query Requests , like this :

## Sample Command And CommandHandler
```csharp

// Use ICommand In Command Model
public class CreateProductCommand : ICommand
{
    public string ProductTitle { get; set; }

    public string ProductName { get; set; }
}
#region Handle
// Use ICommandHandler In Command Handler

public async ValueTask<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
{
   var createProduct = GenereateCreateProductDtoFromaCommand(request);

   await _productRepository.CreateProduct(createProduct).ConfigureAwait(false);

   return Unit.Value;
}
#endregion

#region Private

private Product GenereateCreateProductDtoFromaCommand(CreateProductCommand command)
   => new Product()
   {
       //Map
   };

#endregion Private
```
## Sample Query And QueryHandler

```csharp
// Use IQuery In Query Model 
public class GetProductQuery : IQuery<IEnumerable<ProductVM>>
{
    public int ProductId { get; set; }
}

#region Handle
// Use IQueryHandler In Query Handler

public async ValueTask<IEnumerable<ProductVM>> Handle(GetProductQuery request, CancellationToken cancellationToken)
{
   var products = await _productService.GetProduct().ConfigureAwait(false);

   var productVMs = CreateProductVM(products);

   return productVMs;
}

#endregion

#region Private

private IEnumerable<ProductVM> CreateProductVM(IEnumerable<Product> products)
{
   IEnumerable<ProductVM> productVMs = new List<ProductVM>();
   foreach (var product in products)
       new List<ProductVM>();

   return productVMs;
}

#endregion Private
```

