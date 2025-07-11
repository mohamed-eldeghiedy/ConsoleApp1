

namespace Assignment06_oop
{
    //public class Duration
    //{
    //    public int Hours { get; set; }
    //    public int Minutes { get; set; }
    //    public int Seconds { get; set; }
    //    public Duration(int hours = 0, int minutes = 0, int seconds = 0)
    //    {
    //        Hours = hours;
    //        Minutes = minutes;
    //        Seconds = seconds;
    //    }
    //    public void Display1()
    //    {
    //        Console.WriteLine($"Duration: {Hours}h {Minutes}m {Seconds}s");
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Hours}h {Minutes}m {Seconds}s";
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null || GetType() != obj.GetType())
    //            return false;

    //        Duration other = (Duration)obj;
    //        return Hours == other.Hours &&
    //               Minutes == other.Minutes &&
    //               Seconds == other.Seconds;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(Hours, Minutes, Seconds);
    //    }

    //    public void Display2()
    //    {
    //        Console.WriteLine(ToString());
    //    }
    //}

    #region //public class Duration
    //public class Duration
    //{
    //    public int Hours { get; private set; }
    //    public int Minutes { get; private set; }
    //    public int Seconds { get; private set; }


    //    public Duration(int hours, int minutes, int seconds)
    //    {
    //        Hours = hours;
    //        Minutes = minutes;
    //        Seconds = seconds;
    //        Normalize();
    //    }

    //    public Duration(int totalSeconds)
    //    {
    //        Hours = totalSeconds / 3600;
    //        totalSeconds %= 3600;
    //        Minutes = totalSeconds / 60;
    //        Seconds = totalSeconds % 60;
    //    }

    //    private void Normalize()
    //    {
    //        int total = Hours * 3600 + Minutes * 60 + Seconds;
    //        Hours = total / 3600;
    //        total %= 3600;
    //        Minutes = total / 60;
    //        Seconds = total % 60;
    //    }

    //    public override string ToString()
    //    {
    //        string result = "";
    //        if (Hours > 0)
    //            result += $"Hours: {Hours}, ";

    //        if (Minutes > 0 || Hours > 0)
    //            result += $"Minutes: {Minutes}, ";

    //        result += $"Seconds: {Seconds}";
    //        return result;
    //    }
    //}
    #endregion

    public class Duration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }


        public Duration(int hours, int minutes, int seconds)
        {
            int total = hours * 3600 + minutes * 60 + seconds;
            SetFromTotalSeconds(total);
        }

        public Duration(int totalSeconds)
        {
            SetFromTotalSeconds(totalSeconds);
        }

        private void SetFromTotalSeconds(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        public int ToTotalSeconds() => Hours * 3600 + Minutes * 60 + Seconds;

        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
                result += $"Hours: {Hours}, ";

            if (Minutes > 0 || Hours > 0)
                result += $"Minutes: {Minutes}, ";

            result += $"Seconds: {Seconds}";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return this.ToTotalSeconds() == other.ToTotalSeconds();
            return false;
        }

        public override int GetHashCode() => ToTotalSeconds().GetHashCode();


        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int result = d1.ToTotalSeconds() - d2.ToTotalSeconds();
            return new Duration(Math.Max(result, 0));
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(d.ToTotalSeconds() - 60, 0));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }


        public static bool operator true(Duration d) => d.ToTotalSeconds() > 0;
        public static bool operator false(Duration d) => d.ToTotalSeconds() <= 0;


        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddSeconds(d.ToTotalSeconds());
        }

    }
}
