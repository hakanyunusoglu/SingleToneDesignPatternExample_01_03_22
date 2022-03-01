using System;
using static BuilderPattern.Pizza;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder(15, "middle");
            pizzaBuilder.withOptionalCheese(true);
            pizzaBuilder.withOptionalOlive(true);

            Pizza pizza = pizzaBuilder.BuildPizza();
            Console.WriteLine(pizza.ToString());
            Console.ReadLine();
        }
    }
}
