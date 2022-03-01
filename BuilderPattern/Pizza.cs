using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pizza
    {
        private int size;
        private string name;
        private bool cheese;
        private bool olive;
        private bool mozarella;
        //public Pizza()
        //{

        //}
        //public Pizza(int size)
        //{

        //}
        //public Pizza(int size,string name)
        //{

        //}
        private Pizza(PizzaBuilder pizzaBuilder)
        {
            this.size = pizzaBuilder.size;
            this.name = pizzaBuilder.name;
            this.olive = pizzaBuilder.olive;
            this.cheese = pizzaBuilder.cheese;
            this.mozarella = pizzaBuilder.mozarella;
        }
        public class PizzaBuilder
        {
            public int size;
            public string name;
            public bool cheese;
            public bool olive;
            public bool mozarella;

            public PizzaBuilder(int size, string name)
            {
                this.size = size;
                this.name = name;
            }
            public PizzaBuilder withOptionalCheese(bool cheese)
            {
                this.cheese = cheese;
                return this;
            }
            public PizzaBuilder withOptionalOlive(bool olive)
            {
                this.olive = olive;
                return this;
            }
            public PizzaBuilder withOptionalMozarella(bool mozarella)
            {
                this.mozarella = mozarella;
                return this;
            }
            public Pizza BuildPizza()
            {
                return new Pizza(this);
            }
        }
    }
}
