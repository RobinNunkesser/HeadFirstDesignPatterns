namespace HeadFirstDesignPatterns.Strategy.Duck
{
    /// <summary>
    /// RubberDuck object
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }

        public override object Display() => "I'm a rubber duck";
    }
}