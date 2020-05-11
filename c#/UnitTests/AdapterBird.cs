using System;
using HeadFirstDesignPatterns.Adapter.Birds;
using Xunit;

namespace UnitTests
{
    public class AdapterBird
    {
        [Fact]
        public void TestMallardDuck()
        {
            Duck mallard = new MallardDuck();
            Assert.Equal("Quack", mallard.Quack());
            Assert.Equal("I'm flying", mallard.Fly());
        }

        [Fact]
        public void TestWildTurkey()
        {
            Turkey wildTurkey = new WildTurkey();
            Assert.Equal("Gooble, gooble", wildTurkey.Gobble());
            Assert.Equal("I'm flying a short distance", wildTurkey.Fly());
        }

        [Fact]
        public void TestTurkeyAdapter()
        {
            Turkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Assert.Equal("Gooble, gooble", turkeyAdapter.Quack());
            Assert.Equal("I'm flying a short distance\n" +
                "I'm flying a short distance\n" +
                "I'm flying a short distance\n" +
                "I'm flying a short distance\n" +
                "I'm flying a short distance\n", turkeyAdapter.Fly());
        }

        [Fact]
        public void TestDuckAdapter()
        {
            Duck mallard = new MallardDuck();
            Turkey duckAdapter = new DuckAdapter(mallard);

            Assert.Equal("Quack", duckAdapter.Gobble());
            Assert.Equal("I'm flying", duckAdapter.Fly());
        }    }
}
