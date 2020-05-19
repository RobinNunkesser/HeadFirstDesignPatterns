namespace HeadFirstDesignPatterns.Adapter.Birds
{
    /// <summary>
    /// Summary description for MallardDuck.
    /// </summary>
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
        }

        #region Duck Members

        public string Quack() => "Quack";

        public string Fly() => "I'm flying";

        #endregion
    }
}