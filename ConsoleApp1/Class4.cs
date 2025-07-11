

namespace Assignment06_oop
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours = 0, int minutes = 0, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public void Display1()
        {
            Console.WriteLine($"Duration: {Hours}h {Minutes}m {Seconds}s");
        }

        public override string ToString()
        {
            return $"{Hours}h {Minutes}m {Seconds}s";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration other = (Duration)obj;
            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public void Display2()
        {
            Console.WriteLine(ToString());
        }
    }
}
