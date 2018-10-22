using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_6
{
    public struct Money
    {
        public Money(string currency, decimal amount) : this()
        {
            Currency = Check.ArgNotNull("currency", currency);
            Amount = amount;
        }

        public string Currency { get; set; }
        public decimal Amount { get; set; }

    }

    //Primary Constructors - just working in VS 2014
    //public struct Money(string currency, decimal amount) 
    //{
    //    public string Currency { get; } = currency;
    //    public decimal Amount { get; } = amount;
    //}

}
