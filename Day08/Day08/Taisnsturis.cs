using System;
using System.Collections.Generic;
using System.Text;

namespace Day08
{
    class Taisnsturis
    {
        public int Xedge { get; set; }
        public int Yedge { get; set; }

        public Taisnsturis(int _Xedge, int _Yedge)
        {
            this.Xedge = _Xedge;
            this.Yedge = _Yedge;
        }

        public void PrintInfo()
        {
            int square = Xedge * Yedge;
            Console.WriteLine("x mala - " + Xedge + " cm.; y mala -  " + Yedge + " cm.; laukums - " + square + " cm2");
        }


    }
    
}
