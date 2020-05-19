namespace HeadFirstDesignPatterns.Strategy.Duck
{
    /// <summary>
    /// FlyWithWings
    /// </summary>
    public class FlyNoWay : IFlyBehavior
    {
        public FlyNoWay()
        {
        }

        #region IFlyBehavior Members

        public object Fly() => "I can't fly.";

        #endregion
    }
}