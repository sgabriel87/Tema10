// See https://aka.ms/new-console-template for more information
// You can create instances of CashRegister, POS, and other necessary objects here

using Tema10.Interfaces;
using Tema10.Models;


CashRegister nr5 = new CashRegister();


Product product = new Product(Product.ProductType.Food, 50);
nr5.ScanProduct(product);
nr5.MakeCashPayment(50);

Product product2 = new Product(Product.ProductType.Electronics, 100);
nr5.ScanProduct(product2);
nr5.MakeCardPayment(100);

Product product3 = new Product(Product.ProductType.Clothing, 70);
nr5.ScanProduct(product3);
IContactless Samsung = new MobilePhone();
nr5.ProvidePOS().AcceptContactlessPayment(100, Samsung, 70);

//failed purchase example.
Product product4 = new Product(Product.ProductType.Clothing, 120);
nr5.ScanProduct(product4);
IContactless Iphone = new MobilePhone();
nr5.ProvidePOS().AcceptContactlessPayment(100, Iphone, 120);


