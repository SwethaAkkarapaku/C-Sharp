using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class ProductPrice
    {
        private double[] prices = new double[4];
        public void AddPrice(int price, int sno)
        {
            prices[sno] = price;
        }
        public double GetPrices(int id)
        {
            return prices[id];
        }
        public double[] GetAllMark()
        {
            return prices;
        }
    }
}
