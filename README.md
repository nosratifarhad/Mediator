# Mediator

## Mediator is similar to mediatR, but one of the differences in its implementation is that

### First If you have the following package installed, uninstall it :
```
MediatR.Extensions.Microsoft.DependencyInjection
```
### Second You need to install the following packages :
```
NuGet\Install-Package Mediator.SourceGenerator 

NuGet\Install-Package Mediator.Abstractions 
```
### Now differences in its implementation is that :

### you don't need send "Assembly" time to add Mediator on project in Startup.cs file . like MediatR : 

```csharp
services.AddMediatR(typeof(Program).Assembly);
//services.AddMediatR(Assembly.GetExecutingAssembly());
```
