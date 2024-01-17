using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance
{
    internal class DancePoints
    {
        public string name;
        public int points;
        public DancePoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancePoints operator +(DancePoints a, DancePoints b)
        {
            string joinName = a.name + " & " + b.name;
            int totalScore = a.points + b.points;
            DancePoints res = new DancePoints(joinName, totalScore);
            return res;
        }
    }
}
