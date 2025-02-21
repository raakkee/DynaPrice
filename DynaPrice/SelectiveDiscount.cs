using System;
using System.Collections.Generic;
using System.Text;

namespace DynaPrice
{
    public class SelectiveDiscountCalculator
{
    public decimal UniversalDiscountPercentage { get; }
    public decimal UPCDiscountPercentage { get; }
    public string UPC { get; }

    public SelectiveDiscountCalculator(decimal universalDiscountPercentage, decimal upcDiscountPercentage, string upc)
    {
        UniversalDiscountPercentage = universalDiscountPercentage;
        UPCDiscountPercentage = upcDiscountPercentage;
        UPC = upc;
    }

    public decimal CalculateDiscount(decimal price)
    {
        decimal universalDiscountAmount = price * (UniversalDiscountPercentage / 100);
        decimal upcDiscountAmount = 0;

        if (UPC == "12345")
        {
            upcDiscountAmount = price * (UPCDiscountPercentage / 100);
        }

        return universalDiscountAmount + upcDiscountAmount;
    }
}
}