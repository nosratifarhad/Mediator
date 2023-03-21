# Mediator

### Second You need to install the following packages :
```
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
### And the Final level for use "Mediator" : 
### You should use "ICommand" and "IQuery" , like this :

```csharp

// ICommand
public class CreateProductCommand : ICommand
{
    public string ProductTitle { get; set; }

    public string ProductName { get; set; }
}

// IQuery
public class GetProductQuery : IQuery<IEnumerable<ProductVM>>
{
    public int ProductId { get; set; }
}

```


