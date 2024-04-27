using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10.Interfaces
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }
}
