using System;
using System.Collections.Generic;
using System.Text;

namespace B3.Domain.Models
{
    public class CDB
    {
        public CDB()
        {
            CDI = 0.009;
            TB = 1.08;
        }

        public double CDI { get; set; }
        public double TB { get; set; }
        public double Months { get; set; }
        public double FinalValue { get; set; }
        public double InitialValue { get; set; }
        public double TaxPercentual { get; set; }
        public double TaxValue { get; set; }
        public double Factor { get; set; }
        public double Value { get; set; }
        public double GrossValue { get; set; }
        public double NetValue { get; set; }
    }
}
