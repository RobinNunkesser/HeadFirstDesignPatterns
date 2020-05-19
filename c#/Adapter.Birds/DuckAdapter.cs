namespace HeadFirstDesignPatterns.Adapter.Birds
{
    /// <summary>
    /// Summary description for TurkeyAdapter.
    /// </summary>
    public class DuckAdapter : Turkey
    {
        Duck duck;

        public DuckAdapter(Duck duck) => this.duck = duck;

        #region Turkey Members

        public string Gobble() => duck.Quack();

        public string Fly() => duck.Fly();

        #endregion
    }
}