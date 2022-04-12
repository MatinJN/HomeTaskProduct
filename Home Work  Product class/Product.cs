using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work__Product_class
{
    internal class Product : Milk
    {
       //Name - mehsulun adi
      //Price - mehsulun qiymeti
      //Count - mehsulun sayi
      //TotalIncome - bu mehsulun satislarindan elde olunan umumi gelir
        private string _name;
        private double _price;
        private int _count;
        private double _totalIncome;

        public Product(string aName)
        {
            Name = aName;
           


        }
        public void Sell ()
        {
             

            if (Count>0)
            {
                Console.WriteLine($"Praduct name {_name}");
                Console.WriteLine($"TotalInCome {_totalIncome += _price}");
                _count --;
                Console.WriteLine($"stock product {_count}");
           
            }
            else
            {
                Console.WriteLine("Mehsul Stockda qalmayib");
            }
            
        }
        public string Name
        { 
            get => _name;

            set 
            {
                _name = value; 
            }
        }
        public double Price 
        {
            get => _price;

            set 
            { 
                _price = value; 
            } 
        }
        public int Count
        {
            get => _count;

            set
            {
                _count = value;
            }
        }
        public double TotalIncome
        {
            get => _totalIncome;

            set
            {
                _totalIncome = value;
            }
        }
        



    }
}
    

