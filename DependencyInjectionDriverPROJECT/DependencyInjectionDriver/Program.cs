// See https://aka.ms/new-console-template for more information

using DependencyInjectionDriver;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
ServiceProvider serviceProvider = services.BuildServiceProvider();

services.AddTransient<IVehicle, Bike>();
services.AddTransient<Driver>();

Driver driver = serviceProvider.GetService<Driver>();
driver.Drive();

//services.AddTransient<IVehicle, Car>();
//services.AddTransient<IVehicle, Truck>();


//IVehicle car = new Car();
//IVehicle truck = new Truck();
//IVehicle bike = new Bike();

//Driver driver = new Driver(truck);
//driver.Drive();

Console.ReadKey();
