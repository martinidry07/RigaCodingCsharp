using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Markup;

namespace Day06
{
    class Car
    {
        public String brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value.Length > 10)
                {
                    brand = "default";
                }
                else
                {
                    brand = value;
                }

            }
        }
        public String model { get; set; }
        private String color;

        public void SetColor(String localColor)
        {
            color = localColor;

        }

        public String GetColor()
        {
            return color;
        }

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + brand + " " + model);
        }
    }

}
