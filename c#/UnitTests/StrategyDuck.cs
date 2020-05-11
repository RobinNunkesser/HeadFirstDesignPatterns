using System;
using HeadFirstDesignPatterns.Strategy.Duck;
using Xunit;

namespace UnitTests
{
    public class StrategyDuck
    {
        [Fact]
        public void TestMallardDuck()
        {
            Duck Mallard = new MallardDuck();
            Assert.Equal("Quack", Mallard.PerformQuack());
            Assert.Equal("I'm flying!!", Mallard.PerformFly());
        }

        [Fact]
        public void TestRubberDuck()
        {
            Duck RubberDuck = new RubberDuck();
            Assert.Equal("Squeak", RubberDuck.PerformQuack());
            Assert.Equal("I can't fly.", RubberDuck.PerformFly());
        }

        [Fact]
        public void TestModelDuck()
        {
            Duck ModelDuck = new ModelDuck();
            Assert.Equal("Quack", ModelDuck.PerformQuack());
            Assert.Equal("I can't fly.", ModelDuck.PerformFly());

            ModelDuck.FlyBehavoir = new FlyRocketPowered();
            Assert.Equal("I'm flying with a rocket!", ModelDuck.FlyBehavoir.Fly());
            Assert.Equal("I'm flying with a rocket!", ModelDuck.PerformFly());

            ModelDuck.QuackBehavior = new MuteQuack();
            Assert.Equal("<<silence>>", ModelDuck.QuackBehavior.Quacking());
            Assert.Equal("<<silence>>", ModelDuck.PerformQuack());
        }
    }
}
