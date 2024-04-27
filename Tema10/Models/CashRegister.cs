using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema10.Services;

namespace Tema10.Models
{
    public class CashRegister
    {
        public void ScanProduct(Product product)
        {
            Console.WriteLine($"\nScanning product: {product.Type}");
            DisplayPrice(product);
        }

        private void DisplayPrice(Product product)
        {

            Console.WriteLine($"Price of {product.Type} product: ${product.Price}");
        }

        public void MakeCashPayment(double amount)
        {
            Console.WriteLine("\nProcessing cash payment...");
            OpenSafe();
            DepositMoney(amount);
            CloseSafe();
            Console.WriteLine("Receipt issued.");
        }

        public POS ProvidePOS()
        {
            return new POS();
        }

        public void MakeCardPayment(double amount)
        {
            POS pos = ProvidePOS();
            Console.WriteLine($"Processing credit card payment for ${amount}...");
            Console.WriteLine("Card payment processed successfully.");
            
        }

        private void OpenSafe()
        {
            Console.WriteLine("Opening safe...");
        }
        private void DepositMoney(double amount)
        {
            Console.WriteLine("Depositing amount: $" + amount);
        }
        private void CloseSafe()
        {
            Console.WriteLine("Closing safe...");
        }
    }
}

