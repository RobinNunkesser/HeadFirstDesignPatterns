using System;
using HeadFirstDesignPatterns.Factory.PizzaStore;
using Xunit;

namespace UnitTests
{
    public class FactoryPizzaStore
    {
        #region TestNYStyleCheesePizza
        [Fact]
        public void TestNYStyleCheesePizza()
        {
            HeadFirstDesignPatterns.Factory.PizzaStore.PizzaStore nyStore =
                new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza("cheese");
            string pizzaPrepareReturn = "Preparing NY Style Sauce and Cheese Pizza\n" +
                "Tossing Thin Crust Dough\n" +
                "Adding Martinara Sauce\n" +
                "Adding toppings:\n" +
                "\tGreated Reggiano Cheese\n";

            Assert.Equal(pizzaPrepareReturn, pizza.Prepare());
            Assert.Equal("Bake for 25 minutes at 350 \n", pizza.Bake());
            Assert.Equal("Cutting the pizza into diagonal slices \n", pizza.Cut());
            Assert.Equal("Place pizza in official PizzaStore box \n", pizza.Box());
            Assert.Equal("NY Style Sauce and Cheese Pizza", pizza.GetName());
        }
        #endregion//TestNYStyleCheesePizza

        #region TestChicagoStyleCheesePizza
        [Fact]
        public void TestChicagoStyleCheesePizza()
        {
            HeadFirstDesignPatterns.Factory.PizzaStore.PizzaStore chicagoStore =
                new ChicagoPizzaStore();
            Pizza pizza = chicagoStore.OrderPizza("cheese");

            string pizzaPrepareReturn = "Preparing Chicago Style Deep Dish Cheese Pizza\n" +
                "Tossing Extra Thick Crust Dough\n" +
                "Adding Plum Tomato Sauce\n" +
                "Adding toppings:\n" +
                "\tShredded Mozzarella Cheese\n";

            Assert.Equal(pizzaPrepareReturn, pizza.Prepare());
            Assert.Equal("Bake for 25 minutes at 350 \n", pizza.Bake());
            Assert.Equal("Cutting the pizza into square slices \n", pizza.Cut());
            Assert.Equal("Place pizza in official PizzaStore box \n", pizza.Box());
            Assert.Equal("Chicago Style Deep Dish Cheese Pizza", pizza.GetName());
        }
        #endregion//TestChicagoStyleCheesePizza
    }
}
