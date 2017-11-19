using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListProcessing
{ 

    public class AppendCommand : Command
    {
        public void AddStringAtTheEnd(string v, List<string> inputLine)
        {
            inputLine.Add(v);
            Console.WriteLine(string.Join(' ',inputLine));
        }
    }
}
