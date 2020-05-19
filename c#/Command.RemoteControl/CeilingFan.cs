namespace HeadFirstDesignPatterns.Command.RemoteControl
{
    /// <summary>
    /// Summary description for CeilingFan.
    /// </summary>
    public class CeilingFan
    {
        public const int HIGH = 2;
        public const int MEDIUM = 1;
        public const int LOW = 0;
        int level;
        string location = "";

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public string High()
        {
            // turns the ceiling fan on to high
            level = HIGH;
            return location + " ceiling fan is on high";
        }

        public string Medium()
        {
            // turns the ceiling fan on to medium
            level = MEDIUM;
            return location + " ceiling fan is on medium";
        }

        public string Low()
        {
            // turns the ceiling fan on to low
            level = LOW;
            return location + " ceiling fan is on low";
        }

        public string Off()
        {
            // turns the ceiling fan off
            level = 0;
            return location + " ceiling fan is off";
        }

        public int GetSpeed()
        {
            return level;
        }
    }
}