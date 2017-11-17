using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListProcessing
{
    public class CountCommand : Command
    {
        public int HowManyTimes(List<string> line, string strToFind)
        {
            int count = line.Where(l => l.Equals(strToFind))
            .Count();

            return count;
        }

    }
}
