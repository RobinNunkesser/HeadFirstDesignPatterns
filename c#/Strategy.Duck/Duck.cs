namespace HeadFirstDesignPatterns.Strategy.Duck
{
    /// <summary>
    /// abstract base class of Ducks
    /// </summary>
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public IQuackBehavior QuackBehavior
        {
            get => quackBehavior;
            set => quackBehavior = value;
        }

        public IFlyBehavior FlyBehavior
        {
            get => flyBehavior;
            set => flyBehavior = value;
        }

        public abstract object Display();

        public object PerformFly() => FlyBehavior.Fly();

        public object PerformQuack() => QuackBehavior.Quacking();

        public string Swim() => "All ducks float, even decoys!";
    }
}