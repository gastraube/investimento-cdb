using B3.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace B3.Domain.Models
{
    public class CDBService : ICDBService
    {
        public CDBService() { }

        public CDB CalculateCDB(double initialValue, int months)
        {
            var cdb = new CDB { };


            cdb.Factor = CalculateFactor(cdb.CDI, cdb.TB, months);
            cdb.FinalValue = CalculateFinalValue(initialValue, cdb.Factor);
            cdb.TaxPercentual = SetTaxPercentual(months);
            cdb.TaxValue = CalculateTaxValue(cdb.TaxPercentual, cdb.FinalValue);
            cdb.GrossValue = CalculateGrossValue(initialValue, cdb.Factor);
            cdb.NetValue = CalculateNetValue(cdb.GrossValue, cdb.TaxValue);

            return cdb;
        }

        public double CalculateGrossValue(double initialValue, double factor)
        {
            return Math.Round(initialValue * factor, 2);
        }


        public double CalculateFinalValue(double initialValue, double factor)
        {
            return initialValue * factor;
        }

        public double SetTaxPercentual(int months)
        {
            if (months > 24) {
                return 15.0 / 100;
            }
            else if (months <= 6)
            {
                return 22.5 / 100;
            }
            else if (months <= 12)
            {
                return 20.0 / 100;
            }
            else if (months <= 24)
            {
                return 17.5 / 100;
            }

            return 0;

        }

        public double CalculateTaxValue(double taxPercentual, double finalValue)
        {
            return taxPercentual * finalValue;
        }

        public double CalculateFactor(double cdi, double tb, int months)
        {
            var result = Math.Pow(1 + (cdi * tb), months);

            if (double.IsInfinity(result)) 
                throw new NotFiniteNumberException();            

            return result;
        }

        public double CalculateNetValue(double grossValue, double taxValue){

            return Math.Round(grossValue - taxValue, 2);
        }
    }
}
