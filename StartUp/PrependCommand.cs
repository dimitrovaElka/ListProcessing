using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListProcessing
{

    public class PrependCommand : Command
    {
        public void AddStringAtTheStart(string v, List<string> inputLine)
        {
            inputLine.Insert(0,v);
            Console.WriteLine(string.Join(' ', inputLine));
        }
    }

}
