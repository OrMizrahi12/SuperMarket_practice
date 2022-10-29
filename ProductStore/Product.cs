using System;
using System.Collections.Generic;
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
            return $" Name: {_name}\n Price: {_price}\n Expretion date: {_date.ToString("dd/MM/yyyy")} \n ----------------";
        } 

       



    }
}
