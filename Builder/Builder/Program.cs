using Builder;

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard medium feature product");
director.BuildMiddlePerformanceProduct();
Console.WriteLine(builder.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.Engine();
builder.Transmission();
Console.WriteLine(builder.GetProduct().ListParts());

//builder.Reset();
Console.WriteLine("Own Builder");
builder.Engine180();
builder.TransmissionSpecial();
builder.Alternator360();
builder.Battery();
builder.Radiator180();
Console.WriteLine(builder.GetProduct().ListParts());