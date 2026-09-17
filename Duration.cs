using System;
using System.Collections.Generic;
using System.Text;

namespace session08C_
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

    
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

       
        public Duration(int totalSeconds) : this(totalSeconds / 3600, (totalSeconds % 3600) / 60, totalSeconds % 60)
        {
        }

       
        public Duration() : this(0, 0, 0)
        {
        }

        public override string ToString()
        {
            if (Hours > 0)
                return "Hours: " + Hours + ", Minutes :" + Minutes + ", Seconds :" + Seconds;
            else
                return "Minutes :" + Minutes + ", Seconds :" + Seconds;
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;

            return false;
        }

      
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
