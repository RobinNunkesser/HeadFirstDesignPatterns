namespace HeadFirstDesignPatterns.Strategy.Duck
{
    /// <summary>
    /// FlyRocketPowered
    /// </summary>
    public class FlyRocketPowered : IFlyBehavior
    {
        #region IFlyBehavior Members

        public object Fly() => "I'm flying with a rocket!";

        #endregion
    }
}