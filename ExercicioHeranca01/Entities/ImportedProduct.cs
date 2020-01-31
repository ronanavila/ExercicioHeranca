using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioHeranca01.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double pricedouble, double customFee)
            : base(name, pricedouble)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return CustomFee + Price;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Fee $ " + CustomFee + ")";
        }

        
    }
}
