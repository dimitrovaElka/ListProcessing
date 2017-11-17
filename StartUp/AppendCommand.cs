using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListProcessing
{ 

    public class AppendCommand : Command
    {
        internal static void AddStringAtTheEnd(string v, string[] inputLine)
        {
            List<string> lst = inputLine.ToList();
            lst.Add(v);
            Console.WriteLine(string.Join(' ',lst));
        }
    }
}
