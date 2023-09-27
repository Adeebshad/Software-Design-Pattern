
using Decorator;

Console.WriteLine("Hello, World!");

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