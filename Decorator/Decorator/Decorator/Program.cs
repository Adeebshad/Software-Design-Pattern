
using Decorator;
using Decorator.Salary;

Console.WriteLine("Hello, World!");

/*

ICar objCar = new LuxuryCar();

//Wrp EconomyCar instancw with BasicAccessories.   
CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

//Wrap EconomyCar instance with AdvancedAccessories instance.   
objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

Console.WriteLine("\n\n");
Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

objAccessoriesDecorator = new AlphaAccessories(objAccessoriesDecorator);

Console.WriteLine("\n\n");
Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());



objAccessoriesDecorator = new AlphaAccessories(objCar);

Console.WriteLine("\n\n");
Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

*/

ISalaryStruct salaryStruct = new Developer();
SalaryDecoder getAmount= new BasicDecoder(salaryStruct);

Console.Write("Salary  Detials: " + getAmount.Description());
Console.WriteLine("\n\n");
Console.Write("Total Amount: " + getAmount.Amount());

getAmount = new AllowanceDecoder(getAmount);
getAmount = new TransportDecoder(getAmount);

Console.WriteLine("\n\n");
Console.Write("Salary  Detials: " + getAmount.Description());
Console.WriteLine("\n\n");
Console.Write("Total Amount: " + getAmount.Amount());