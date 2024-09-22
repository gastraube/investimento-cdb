using B3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace B3.Domain.Interfaces
{
    public interface ICDBService
    {
        CDB CalculateCDB(double initialValue, int months);
        double CalculateGrossValue(double initialValue, double factor);
        double CalculateFinalValue(double initialValue, double factor);
        double SetTaxPercentual(int months);
        double CalculateTaxValue(double taxPercentual, double finalValue);
        double CalculateFactor(double cdi, double tb, int months);
        double CalculateNetValue(double grossValue, double taxValue);
    }
}
