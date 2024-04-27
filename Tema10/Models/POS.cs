using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema10.Interfaces;

namespace Tema10.Services
{
    public class POS
    {
        public void AcceptContactFullPayment(double amount, ICard card)
        {
          Console.WriteLine("Contact-full payment processed successfully.");
        }

        public void AcceptContactlessPayment(double amount, IContactless contactlessDevice, double productPrice)
        {
            if (amount >= productPrice)
            {
                Console.WriteLine("Processing contactless payment...");
                contactlessDevice.MakePayment(amount);
                Console.WriteLine("Contactless payment processed successfully.");
                Console.WriteLine("Receipt issued.");
            }
            else
            {
                Console.WriteLine("Contactless payment failed: Insufficient funds.");
            }
        }

    }
}
