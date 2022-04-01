// See https://aka.ms/new-console-template for more information


//Facade Design Pattern karmaşıklığı azaltarak client a daha temiz bir arayüz sunmayı hedefler.
//Bu tasarım kalıbı bir veya birden fazla sınıfın karmaşıklığını kendi içinde yani cephe(facade) nin ardında gizler.

//Bizim RestaurantFacade sınıfımız olmasaydı o sınıfın içinde yaptıklarımızı da burada client tarafında yapacaktık ve
//burası daha karmaşık bir yapıya sahip olacaktı. Bu durum da kod okunabilirliğine ve sürdürülebilirliğine olumsuz anlamda etki eder.

using FacadeDesignPattern;

Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
var facadeForClient = new RestaurantFacade();
facadeForClient.GetNonVegPizza();
facadeForClient.GetVegPizza();
Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
facadeForClient.GetGarlicBread();
facadeForClient.GetCheesyGarlicBread();

Console.ReadKey();
