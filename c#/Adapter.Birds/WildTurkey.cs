namespace HeadFirstDesignPatterns.Adapter.Birds
{
    /// <summary>
    /// Summary description for WildTurkey.
    /// </summary>
    public class WildTurkey : Turkey
    {
        public WildTurkey()
        {
        }

        #region Turkey Members

        public string Gobble() => "Gooble, gooble";

        public string Fly() => "I'm flying a short distance";

        #endregion
    }
}