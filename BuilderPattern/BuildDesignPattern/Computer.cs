using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuildDesignPattern
{
    public class Computer
    {
        private string Brand { get; set; }
        private string Price { get; set; }
        private string CPU { get; set; }
        private string RAM { get; set; }

        public Computer(string brand, string price, string cpu, string ram)
        {
            this.Brand = brand;
            this.Price = price;
            this.CPU = cpu;
            this.RAM = ram;

        }
    }
}
