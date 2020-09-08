using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    class Car
    {
        public String Brand { get; set; }
        public String model { get; set; }
        public String color { get; set; }

        public Car(String brand, String model, String localColor)
        {
            Brand = brand; //sadi ir pareizak c#
            this.model = model; //sadi var visur, ja nosaukumi vienadi
            color = localColor; //var ari nar dazadiem nosaukumiem
        }

        //overloads- var uztaisit metodes ar vienadiem nosaukumiem
        //bet dazadiem parametriem, return utt
        public Car()
        {
            Brand = "default";
            model = "default";
            color = "default";
        }

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + Brand + " " + model);
        }
    }
}
