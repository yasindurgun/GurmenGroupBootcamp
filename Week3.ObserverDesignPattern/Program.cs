// See https://aka.ms/new-console-template for more information
using Week3.ObserverDesignPattern.Handlers;
using Week3.ObserverDesignPattern.Models;
using Week3.ObserverDesignPattern.Observers;



//öncelikle bir subject oluşturmam gerekiyor
var subject = new ProductObserverSubject();
var product1 = new Product(1,"Product1");
var product2 = new Product(2,"Product2");
var product3 = new Product(3,"Product3");

ProductCreatedEventSendEmailHandler mailHandler = new ProductCreatedEventSendEmailHandler();
ProductCreatedEventSendSmsHandler smsHandler = new ProductCreatedEventSendSmsHandler();

subject.RegisterObserver(mailHandler);
subject.RegisterObserver(smsHandler);

//Nesneler oluştuğunda ilgili subject üzerinden handlerlar çalışıyor.
subject.NotifyObserver(product3);

Console.WriteLine("****************");

subject.NotifyObserver(product1);

Console.WriteLine("****************");

subject.NotifyObserver(product2);

Console.ReadKey();