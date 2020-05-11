using System;
using System.Text;
using HeadFirstDesignPatterns.TemplateMethod.CaffeineBeverage;
using Xunit;

namespace UnitTests
{
    public class TemplateMethodCaffeine : IDisposable
    {
        #region Members
        Tea tea;
        Coffee coffee;
        CoffeeWithHook coffeeWithHook;
        TeaWithHook teaWithHook;
        StringBuilder teaResult;
        StringBuilder coffeeResult;
        StringBuilder coffeeWithHookYesResult;
        StringBuilder coffeeWithHookNoResult;
        StringBuilder teaWithHookYesResult;
        StringBuilder teaWithHookNoResult;
        #endregion//Members

        #region Init()
        public TemplateMethodCaffeine()
        {
            tea = new Tea();
            coffee = new Coffee();
            coffeeWithHook = new CoffeeWithHook();
            teaWithHook = new TeaWithHook();
            teaResult = new StringBuilder();
            coffeeResult = new StringBuilder();
            coffeeWithHookYesResult = new StringBuilder();
            coffeeWithHookNoResult = new StringBuilder();
            teaWithHookYesResult = new StringBuilder();
            teaWithHookNoResult = new StringBuilder();
        }
        #endregion// SetUp Init()

        #region TestCleanup Dispose()
        public void Dispose()
        {
            tea = null;
            coffee = null;
            coffeeWithHook = null;
            teaWithHook = null;
            teaResult = null;
            coffeeResult = null;
            coffeeWithHookYesResult = null;
            coffeeWithHookNoResult = null;
            teaWithHookYesResult = null;
            teaWithHookNoResult = null;
        }
        #endregion//TearDown Dispose()

        #region TestTea
        [Fact]
        public void TestTea()
        {
            teaResult.Append("Boiling water\n");
            teaResult.Append("Steeping the tea\n");
            teaResult.Append("Pouring into cup\n");
            teaResult.Append("Adding lemon\n");
            Assert.Equal(teaResult.ToString(), tea.PrepareRecipe());
        }
        #endregion//TestTea

        #region TestCoffee
        [Fact]
        public void TestCoffee()
        {
            coffeeResult.Append("Boiling water\n");
            coffeeResult.Append("Dripping coffee through filter\n");
            coffeeResult.Append("Pouring into cup\n");
            coffeeResult.Append("Adding sugar and milk\n");
            Assert.Equal(coffeeResult.ToString(), coffee.PrepareRecipe());
        }
        #endregion//TestCoffee

        #region TestCoffeeWithHook
        [Fact]
        public void TestCoffeeWithHook()
        {
            if (coffeeWithHook.CustomerWantsCondiments())
            {
                coffeeWithHookYesResult.Append("Boiling water\n");
                coffeeWithHookYesResult.Append("Dripping coffee through filter\n");
                coffeeWithHookYesResult.Append("Pouring into cup\n");
                coffeeWithHookYesResult.Append("Adding sugar and milk\n");
                Assert.Equal(coffeeWithHookYesResult.ToString(),
                    coffeeWithHook.PrepareRecipe());
            }
            else
            {
                coffeeWithHookNoResult.Append("Boiling water\n");
                coffeeWithHookNoResult.Append("Dripping coffee through filter\n");
                coffeeWithHookNoResult.Append("Pouring into cup\n");
                Assert.Equal(coffeeWithHookNoResult.ToString(),
                    coffeeWithHook.PrepareRecipe());
            }
        }
        #endregion//TestCoffeeWithHook

        #region TestTeaWithHook
        [Fact]
        public void TestTeaWithHook()
        {
            if (teaWithHook.CustomerWantsCondiments())
            {
                teaWithHookYesResult.Append("Boiling water\n");
                teaWithHookYesResult.Append("Steeping the tea\n");
                teaWithHookYesResult.Append("Pouring into cup\n");
                teaWithHookYesResult.Append("Adding lemon\n");
                Assert.Equal(teaWithHookYesResult.ToString(),
                    teaWithHook.PrepareRecipe());
            }
            else
            {
                teaWithHookNoResult.Append("Boiling water\n");
                teaWithHookNoResult.Append("Steeping the tea\n");
                teaWithHookNoResult.Append("Pouring into cup\n");
                Assert.Equal(teaWithHookNoResult.ToString(),
                    teaWithHook.PrepareRecipe());
            }
        }
        #endregion//TestTeaWithHook
    }
}
