using AppOne;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Using .NET Built-in Dependency injection to print hello world !");

        // Setup service collection
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        // Build a service provider from the service collection
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Use the service provider to resolve an instance of MyClass
        var myClass = serviceProvider.GetService<MyClass>();

        // Use the Instance
        myClass.DoSomething();

    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<MyClass>();
    }
}