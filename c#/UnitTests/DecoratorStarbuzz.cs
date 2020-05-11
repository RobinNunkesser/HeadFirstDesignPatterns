using System;
using HeadFirstDesignPatterns.Decorator.Starbuzz;
using Xunit;
namespace UnitTests
{
    public class DecoratorStarbuzz
    {
        #region TestExpresso
        [Fact]
        public void TestExpresso()
        {
            Beverage beverage = new Expresso();
            Assert.Equal("Expresso $1.5", beverage.GetDescription() +
                " $" + beverage.Cost());
        }
        #endregion//TestExpresso

        #region TestExpressoWithSize
        [Fact]
        public void TestExpressoWithSize()
        {
            BeverageSize beverageSize = BeverageSize.GRANDE;
            Beverage beverage = new Expresso();
            beverage.Size = beverageSize;
            beverage = new Mocha(beverage);
            beverage.Size = beverageSize;
            Assert.Equal("Expresso, Mocha $1.9", beverage.GetDescription() +
                " $" + beverage.Cost());
        }
        #endregion//TestExpressoWithSize

        #region TestHouseBlend
        [Fact]
        public void TestHouseBlend()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new SteamedMilk(beverage);
            Assert.Equal("House Blend Coffee, Mocha, Steamed Milk $1.09", beverage.GetDescription() +
                " $" + beverage.Cost());
        }
        #endregion//TestHouseBlend

        #region TestDarkRoast
        [Fact]
        public void TestDarkRoast()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            Assert.Equal("Dark Roast Coffee, Mocha, Soy $1.34", beverage.GetDescription() +
                " $" + beverage.Cost());
        }
        #endregion//TestDarkRoast

        #region TestDecaf
        [Fact]
        public void TestDecaf()
        {
            Beverage beverage = new Decaf();
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Assert.Equal("Decaf Coffee, Mocha, Whip $1.35", beverage.GetDescription() +
                " $" + beverage.Cost());
        }
        #endregion//TestDecaf    
    }
}
