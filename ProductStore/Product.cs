using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    internal class Product
    {
        private string _name;
        private double _price;
        private DateTime _date;

        public Product(string name, double price, int days)
        {
            DateTime day = DateTime.Now;
            _name = name;
            _price = price;
            _date = day.AddDays(days);
        }

        public override string ToString()
        {
            string receiving = $" Product name: {_name}\n Price: {string.Format("{0:C}", _price)}\n Expretion date: {_date} \n ----------------";
            return receiving;
        } 
    }
}